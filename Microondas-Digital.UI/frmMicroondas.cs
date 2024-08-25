using Microondas_Digital.BLL.Manager;
using Microondas_Digital.DAL.Data.Interfaces;
using Microondas_Digital.DAL.Data.Mock;
using Microondas_Digital.DAL.Models;
using Microondas_Digital.Utils.Shared.Constants;
using Microsoft.Extensions.DependencyInjection;

namespace Microondas_Digital.UI;

public partial class fmMicroondas : Form
{
    private readonly IServiceProvider _serviceProvider;
    private TemporizadorManager _temporizadorManager;
    private AcessoDadosManager _acesoDadosManager;
    private List<ProgramaPersonalizado> _programasPersonalizados = new List<ProgramaPersonalizado>();
    private List<ProgramaPadrao> _programasPadroes = new List<ProgramaPadrao>();
    private ProgramaPersonalizado? _programaPersonalizado;
    private ProgramaPadrao? _programaPadrao;
    private static int? _tempoAtual;
    private bool _primeiraVezLigado = true;

    public fmMicroondas(IAcessoDadosRepository dadosRepository, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        InicializarTemporizador();

        _serviceProvider = serviceProvider;
        _temporizadorManager = new TemporizadorManager();
        _acesoDadosManager = new AcessoDadosManager(dadosRepository);

        LoadProgramasPadrao();
        LoadProgramasPersonalizados();
    }

    private void Ligar()
    {
        btnLigarAcrescentarTempo.Enabled = false;

        if (_primeiraVezLigado)
        {
            // Configura caso seja selecionado um programa personalizado.
            if (_programaPersonalizado != null && _programaPersonalizado.Nome != "Selecione...")
            {
                _temporizadorManager.Potencia = _programaPersonalizado.Potencia;
                _temporizadorManager.Tempo = _programaPersonalizado.Tempo;
            }
            // Configura caso seja selecionado um programa padrão.
            else if (_programaPadrao != null && _programaPadrao.Nome != "Selecione...")
            {
                _temporizadorManager.Potencia = _programaPadrao.Potencia;
                _temporizadorManager.Tempo = _programaPadrao.Tempo;
            }
            else
            {
                // Valida caso seja informado um tempo/potência manualmente.
                if (!_temporizadorManager.ValidarTempo(txtTempo.Text, txtPotencia.Text))
                {
                    MessageBox.Show(SharedConstants.MensagemErroCamposInvalidos, "Atenção!", MessageBoxButtons.OK);
                    btnLigarAcrescentarTempo.Enabled = true;
                    return;
                }

                if (!int.TryParse(txtTempo.Text, out int tempo) || tempo <= 0 || tempo > 120)
                {
                    tempo = 30;
                }

                if (!int.TryParse(txtPotencia.Text, out int potencia) || potencia <= 0 || potencia > 10)
                {
                    potencia = 10;
                }

                _temporizadorManager.Potencia = potencia;
                _temporizadorManager.Tempo = tempo;
            }
            _primeiraVezLigado = false;
        }
        else
        {

            // Valida caso seja informado um tempo/potência manualmente, programa padrão/personalizado, ou caso não esteja pausado.
            if (_programaPersonalizado == null && _programaPadrao == null && !_temporizadorManager.IsPausado)
            {
                if (!_temporizadorManager.ValidarTempo(txtTempo.Text, txtPotencia.Text))
                {
                    MessageBox.Show(SharedConstants.MensagemErroCamposInvalidos, "Atenção!", MessageBoxButtons.OK);
                    btnLigarAcrescentarTempo.Enabled = true;
                    return;
                }

                if (!int.TryParse(txtTempo.Text, out int tempo) || tempo <= 0 || tempo > 120)
                    tempo = 30;

                if (!int.TryParse(txtPotencia.Text, out int potencia) || potencia <= 0 || potencia > 10)
                    potencia = 10;

                _temporizadorManager.Potencia = potencia;
                _temporizadorManager.Tempo = tempo;
            }
        }

        // Desativa a opção de digitar enquanto o microondas estiver ligado.
        txtTempo.Enabled = false;
        txtPotencia.Enabled = false;

        // Atualiza a tela com a potência.
        lblPot.Text = $"POTÊNCIA ({_temporizadorManager.Potencia})";

        // Caso esteja pausado só continua.
        if (_temporizadorManager.IsPausado)
        {
            _temporizadorManager.Iniciar();
            timer.Start();
        }
        // Caso não seja programa padrão/personalizado adiciona 30 segundos.
        else if (_temporizadorManager.IsLigado && _programaPersonalizado == null && _programaPadrao == null)
        {
            _temporizadorManager.AdicionarTempo(_tempoAtual);
            AtualizarVisor(_temporizadorManager.Tempo);
        }
        // Liga normalmente.
        else
        {
            AtualizarVisor(_temporizadorManager.Tempo);
            _temporizadorManager.Iniciar();
            timer.Start();
        }

        // Atraso de habilitação do botão para acrescentar os 30 segundos corretamente.
        Task.Delay(1000).ContinueWith(t => btnLigarAcrescentarTempo.Invoke((Action)(() => btnLigarAcrescentarTempo.Enabled = true)));
    }

    private void Pausar()
    {
        // Pausa normalmente.
        if (_temporizadorManager.IsLigado)
        {
            _temporizadorManager.Pausar();
            timer.Stop();
        }
        // Cancela a operação.
        else if (_temporizadorManager.IsPausado)
        {
            _temporizadorManager.Cancelar();
            timer.Stop();
            AtualizarVisor(0, "00:00");
            lblPot.Text = "";
            txtTempo.Enabled = true;
            txtPotencia.Enabled = true;
            ResetInfoProgramas();
            _programaPersonalizado = null;
            _programaPadrao = null;
            cboProgramasCustomizados.Enabled = true;
            cboProgramasPadrao.Enabled = true;
        }
        // Reseta o microondas.
        else
        {
            _temporizadorManager.Cancelar();
            timer.Stop();
            AtualizarVisor(0, "00:00");
            txtPotencia.Text = "";
            txtTempo.Text = "";
            lblPot.Text = "";
            txtTempo.Enabled = true;
            txtPotencia.Enabled = true;
            ResetInfoProgramas();
            _programaPersonalizado = null;
            _programaPadrao = null;
            cboProgramasCustomizados.Enabled = true;
            cboProgramasPadrao.Enabled = true;
        }
    }

    private void btnLigarAcrescentarTempo_Click(object sender, EventArgs e)
    {
        Ligar();
    }

    private void btnPausarCancelar_Click(object sender, EventArgs e)
    {
        Pausar();
    }

    private void btnGerenciarProgramas_Click(object sender, EventArgs e)
    {
        var frmGerenciamentoProgramas = _serviceProvider.GetRequiredService<frmGerenciamentoProgramas>();

        // Associa o evento OnDbChange do formulário ao método AtualizarListaProgramas
        // para garantir que a lista de programas personalizados seja atualizada quando houver alterações (adições, edições ou exclusões).
        frmGerenciamentoProgramas.OnDbChange += AtualizarListaProgramas;

        frmGerenciamentoProgramas.ShowDialog();
    }

    private void cboProgramasCustomizados_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Preenche a lista de programas customizados e inicia o aquecimento.
        var selecionado = cboProgramasCustomizados.SelectedItem as ProgramaPersonalizado;

        if (selecionado != null && selecionado.Nome != "Selecione...")
        {
            _programaPersonalizado = selecionado;

            txtIdentificador.Visible = true;
            lblIdentificador.Visible = true;
            cboProgramasPadrao.Enabled = false;

            txtNomePrograma.Text = selecionado.Nome;
            txtAlimentoPrograma.Text = selecionado.Alimento;
            txtTempoPrograma.Text = _temporizadorManager.ConverteSegundosMinutos(selecionado.Tempo);
            txtPotenciaPrograma.Text = selecionado.Potencia.ToString();
            txtInstrucoesPrograma.Text = selecionado.Instrucoes;
            txtIdentificador.Text = selecionado.CaractereAquecimento.ToString();

            _temporizadorManager.Potencia = selecionado.Potencia;
            _temporizadorManager.Tempo = selecionado.Tempo;
            _tempoAtual = selecionado.Tempo;

            AtualizarVisor(_temporizadorManager.Tempo);

            Ligar();
        }
    }

    private void cboProgramasPadrao_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Preenche a lista de programas padrão e inicia o aquecimento.
        var selecionado = cboProgramasPadrao.SelectedItem as ProgramaPadrao;

        if (selecionado != null && selecionado.Nome != "Selecione...")
        {
            _programaPadrao = selecionado;

            cboProgramasCustomizados.Enabled = false;

            txtNomePrograma.Text = selecionado.Nome;
            txtAlimentoPrograma.Text = selecionado.Alimento;
            txtTempoPrograma.Text = _temporizadorManager.ConverteSegundosMinutos(selecionado.Tempo);
            txtPotenciaPrograma.Text = selecionado.Potencia.ToString();
            txtInstrucoesPrograma.Text = selecionado.Instrucoes;
            txtIdentificador.Text = selecionado.CaractereAquecimento.ToString();

            _temporizadorManager.Potencia = selecionado.Potencia;
            _temporizadorManager.Tempo = selecionado.Tempo;
            _tempoAtual = selecionado.Tempo;

            AtualizarVisor(_temporizadorManager.Tempo);

            Ligar();
        }
    }

    private void Temporizador_Tick(object sender, EventArgs e)
    {
        // Método responsável por:
        // 1. Verificar se o temporizador está ativo e o tempo restante é positivo.
        // 2. Decrementar o tempo restante a cada tique do Timer.
        // 3. Emitir sinais sonoros conforme o tempo restante e finalizar o temporizador quando o tempo chegar a zero.
        // 4. Atualizar a interface do usuário para refletir o tempo restante e lidar com o final do temporizador,
        //    incluindo reabilitar campos de entrada e limpar informações relacionadas ao programa.

        if (_temporizadorManager.ContinuaRodando && _temporizadorManager.Tempo > 0)
        {
            _temporizadorManager.DecrementarTempo();
            _tempoAtual = _temporizadorManager.Tempo;

            if (_temporizadorManager.Tempo <= 0)
            {
                Console.Beep(1500, 1500);
                _temporizadorManager.Finalizar();
                timer.Stop();
                AtualizarVisor(0, "00:00");
                ResetInfoProgramas();
                lblPot.Text = "";
                txtTempo.Text = "";
                txtPotencia.Text = "";
                txtTempo.Enabled = true;
                txtPotencia.Enabled = true;
                _primeiraVezLigado = true;
            }
            else if (_temporizadorManager.Tempo <= 3)
                Console.Beep(1000, 500);

            AtualizarVisor(_temporizadorManager.Tempo);
        }
    }

    private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
    {
        // Validação para permitir somente números
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }

    private void txtPotencia_KeyPress(object sender, KeyPressEventArgs e)
    {
        // Validação para permitir somente números
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }

    private void ResetInfoProgramas()
    {
        // Reseta as informações dos programas
        txtNomePrograma.Text = "";
        txtAlimentoPrograma.Text = "";
        txtTempoPrograma.Text = "";
        txtPotenciaPrograma.Text = "";
        txtInstrucoesPrograma.Text = "";
        txtIdentificador.Text = "";
        cboProgramasCustomizados.SelectedIndex = 0;
        cboProgramasPadrao.SelectedIndex = 0;
    }

    private void AtualizarListaProgramas()
    {
        try
        {
            // Método responsável por atualizar a lista de programas personalizados ao adicionar ou editar um item.
            var programas = _acesoDadosManager.GetProgramasPersonalizados();
            programas.Insert(0, new ProgramaPersonalizado { Nome = "Selecione..." });

            cboProgramasCustomizados.DataSource = null;
            cboProgramasCustomizados.DataSource = programas;
            cboProgramasCustomizados.DisplayMember = "Nome";
            cboProgramasCustomizados.ValueMember = "Id";
            cboProgramasCustomizados.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao atualizar a lista de programas: {ex.Message}");
        }
    }

    private void AtualizarVisor(int tempo, string message = "")
    {
        if (string.IsNullOrEmpty(message) && tempo > 0)
            lblVisor.Text = _temporizadorManager.ConverteSegundosMinutos(tempo);
        else
            lblVisor.Text = message;
    }

    private void LoadProgramasPersonalizados()
    {
        // Método responsável por carregar a lista de programas personalizados.
        _programasPersonalizados = _acesoDadosManager.GetProgramasPersonalizados();
        _programasPersonalizados.Insert(0, new ProgramaPersonalizado { Nome = "Selecione..." });
        cboProgramasCustomizados.DataSource = _programasPersonalizados;
        cboProgramasCustomizados.DisplayMember = "Nome";
        cboProgramasCustomizados.ValueMember = "Id";
    }

    private void LoadProgramasPadrao()
    {
        // Método responsável por carregar a lista de programas padrão.
        _programasPadroes = MockProgramas.GetProgramasPadrao();
        _programasPadroes.Insert(0, new ProgramaPersonalizado { Nome = "Selecione..." });
        cboProgramasPadrao.DataSource = _programasPadroes;
        cboProgramasPadrao.DisplayMember = "Nome";
    }

    private void InicializarTemporizador()
    {
        // Método responsável por configurar o timer.
        timer = new System.Windows.Forms.Timer();
        timer.Interval = 1000;
        timer.Tick += Temporizador_Tick;
    }
}
