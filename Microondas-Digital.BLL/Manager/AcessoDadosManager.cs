using Microondas_Digital.DAL.Data.Interfaces;
using Microondas_Digital.DAL.Models;
using Microondas_Digital.Utils.Shared.Constants;
using Microondas_Digital.Utils.Shared.Exceptions;

namespace Microondas_Digital.BLL.Manager;

public class AcessoDadosManager
{
    private readonly IAcessoDadosRepository _repository;

    public AcessoDadosManager(IAcessoDadosRepository repository)
    {
        _repository = repository;
    }

    public List<ProgramaPersonalizado> GetProgramasPersonalizados()
    {
        return _repository.GetAll();
    }

    public ProgramaPersonalizado? GetProgramaPersonalizadoById(long id)
    {
        return _repository.GetById(id);
    }

    public bool CreateProgramaPersonalizado(ProgramaPersonalizado programaPersonalizado)
    {
        ValidaCampos(programaPersonalizado);
        return _repository.Create(programaPersonalizado);
    }

    public bool UpdateProgramaPersonalizado(ProgramaPersonalizado programaPersonalizado)
    {
        return _repository.Update(programaPersonalizado);
    }

    public bool DeleteProgramaPersonalizado(long id)
    {
        if (id <= 0)
            throw new CampoInvalidoException("Atenção, informe um itém válido para a exclusão.");

        return _repository.Delete(id);
    }

    private void ValidaCampos(ProgramaPersonalizado programaPersonalizado)
    {
        if (string.IsNullOrEmpty(programaPersonalizado.Nome))
            throw new CampoInvalidoException("Atenção, nome do programa é obrigatório.");

        if (string.IsNullOrEmpty(programaPersonalizado.Alimento))
            throw new CampoInvalidoException("Atenção, alimento do programa é obrigatório.");

        if (programaPersonalizado.Tempo <= 0 || programaPersonalizado.Tempo > 120)
            throw new ValorInvalidoException("Tempo", 1, 120);

        if (programaPersonalizado.Potencia <= 0 || programaPersonalizado.Potencia > 10)
            throw new ValorInvalidoException("Potência", 1, 10);
    }

    public void ValidaCaracteresAquecimento(List<ProgramaPersonalizado> dadosCadastrados, List<ProgramaPadrao> programasPadrao, ProgramaPersonalizado programaPersonalizado)
    {
        // Verifica se o caractere de aquecimento é inválido ('.' não permitido)
        if (programaPersonalizado.CaractereAquecimento == '.')
        {
            throw new CampoInvalidoException("Atenção, o caractere de aquecimento '.' não pode ser utilizado.");
        }

        // Verifica se o caractere de aquecimento já foi utilizado por outro programa personalizado
        bool caractereRepetidoEmOutroPrograma = dadosCadastrados
            .Any(x => x.CaractereAquecimento == programaPersonalizado.CaractereAquecimento && x.Nome != programaPersonalizado.Nome);

        if (caractereRepetidoEmOutroPrograma)
        {
            throw new CampoInvalidoException(SharedConstants.MensagemErroCaractereAquecimento);
        }

        // Verifica se o caractere de aquecimento já está utilizado em programas padrão
        if (programasPadrao.Any(x => x.CaractereAquecimento == programaPersonalizado.CaractereAquecimento))
        {
            throw new CampoInvalidoException(SharedConstants.MensagemErroCaractereAquecimento);
        }
    }
}
