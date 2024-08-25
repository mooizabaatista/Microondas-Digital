using Microondas_Digital.BLL.Manager;
using Microondas_Digital.DAL.Data.Interfaces;
using Microondas_Digital.DAL.Data.Mock;
using Microondas_Digital.DAL.Models;
using Microondas_Digital.Utils.Shared.Exceptions;

namespace Microondas_Digital.UI;

public partial class frmGerenciamentoProgramas : Form
{
    private AcessoDadosManager _acesoDadosManager;
    private List<ProgramaPersonalizado> _programasPersonalizados = new List<ProgramaPersonalizado>();
    private List<ProgramaPadrao> _programasPadrao = new List<ProgramaPadrao>();
    public event Action? OnDbChange;

    public frmGerenciamentoProgramas(IAcessoDadosRepository dadosRepository)
    {
        InitializeComponent();

        _acesoDadosManager = new AcessoDadosManager(dadosRepository);
        _programasPersonalizados = _acesoDadosManager.GetProgramasPersonalizados();
        _programasPadrao = MockProgramas.GetProgramasPadrao();

        // CRIAR MÉTODO PRA ISSO
        lstProgramas.DataSource = _programasPersonalizados;
        lstProgramas.ValueMember = "Id";
        lstProgramas.DisplayMember = "Nome";
        ResetarCampos();
    }

    private void lstProgramas_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selecionado = lstProgramas.SelectedItem as ProgramaPersonalizado;

        if (selecionado != null && selecionado.Nome != "")
        {
            txtIdPrograma.Text = selecionado.Id.ToString();
            txtNomePrograma.Text = selecionado.Nome;
            txtAlimentoPrograma.Text = selecionado.Alimento;
            txtTempoPrograma.Text = selecionado.Tempo.ToString();
            txtPotenciaPrograma.Text = selecionado.Potencia.ToString();
            txtInstrucoesPrograma.Text = selecionado.Instrucoes;
            txtSimboloAquecimento.Text = selecionado.CaractereAquecimento.ToString();
        }
    }


    private void ResetarCampos()
    {
        lstProgramas.SelectedIndex = -1;
        txtIdPrograma.Text = "";
        txtNomePrograma.Text = "";
        txtAlimentoPrograma.Text = "";
        txtTempoPrograma.Text = "";
        txtPotenciaPrograma.Text = "";
        txtInstrucoesPrograma.Text = "";
        txtSimboloAquecimento.Text = "";
    }

    private void btnResetarCampos_Click(object sender, EventArgs e)
    {
        ResetarCampos();
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtNomePrograma.Text) ||
                string.IsNullOrWhiteSpace(txtAlimentoPrograma.Text) ||
                !int.TryParse(txtTempoPrograma.Text, out int tempo) ||
                !int.TryParse(txtPotenciaPrograma.Text, out int potencia) ||
                !char.TryParse(txtSimboloAquecimento.Text, out char caractereAquecimento))
            {
                throw new CampoInvalidoException("Todos os campos com * são obrigatórios e devem estar no formato correto.");
            }

            var programaPersonalizado = new ProgramaPersonalizado
            {
                Nome = txtNomePrograma.Text,
                Alimento = txtAlimentoPrograma.Text,
                Tempo = tempo,
                Potencia = potencia,
                CaractereAquecimento = caractereAquecimento,
                Instrucoes = txtInstrucoesPrograma.Text
            };

            _acesoDadosManager.ValidaCaracteresAquecimento(_programasPersonalizados, _programasPadrao, programaPersonalizado);

            if (string.IsNullOrEmpty(txtIdPrograma.Text))
            {
                _acesoDadosManager.CreateProgramaPersonalizado(programaPersonalizado);
                MessageBox.Show("Programa criado com sucesso.");
            }
            else
            {
                programaPersonalizado.Id = int.Parse(txtIdPrograma.Text);
                _acesoDadosManager.UpdateProgramaPersonalizado(programaPersonalizado);
                MessageBox.Show("Programa atualizado com sucesso.");
            }

            AtualizarListaProgramas();
            ResetarCampos();

            OnDbChange?.Invoke();
        }
        catch (CampoInvalidoException ex)
        {
            MessageBox.Show(ex.Message);
        }
        catch (ValorInvalidoException ex)
        {
            MessageBox.Show(ex.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro inesperado: {ex.Message}");
        }
    }

    private void txtTempoPrograma_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }

    private void txtPotenciaPrograma_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }

    private void AtualizarListaProgramas()
    {
        try
        {
            lstProgramas.DataSource = null;
            lstProgramas.DataSource = _acesoDadosManager.GetProgramasPersonalizados();
            lstProgramas.DisplayMember = "Nome";
            lstProgramas.ValueMember = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao atualizar a lista de programas: {ex.Message}");
        }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtIdPrograma.Text))
            MessageBox.Show("Atenção, selecione um item para excluir.");
        else
        {
            try
            {
                _acesoDadosManager.DeleteProgramaPersonalizado(int.Parse(txtIdPrograma.Text));
                AtualizarListaProgramas();
                ResetarCampos();
                MessageBox.Show("Programa excluído com sucesso.");
                OnDbChange?.Invoke();
            }
            catch (CampoInvalidoException campoInvalidoEx)
            {
                MessageBox.Show(campoInvalidoEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
