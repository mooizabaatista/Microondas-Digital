using Microondas_Digital.DAL.Models;

namespace Microondas_Digital.DAL.Data.Mock;

public class MockProgramas
{
    public static List<ProgramaPadrao> GetProgramasPadrao()
    {
        List<ProgramaPadrao> programasPadrao = new List<ProgramaPadrao>();

        return new List<ProgramaPadrao>
    {
        CriarProgramaPadrao("Pipoca", "Pipoca (de micro-ondas)", 180, 7, '!' , "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento."),
        CriarProgramaPadrao("Leite", "Leite", 300, 5, '@', "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras."),
        CriarProgramaPadrao("Carnes de boi", "Carne em pedaço ou fatias", 840, 4, '#', "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme."),
        CriarProgramaPadrao("Frango", "Frango (qualquer corte)", 480, 7, '$', "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme."),
        CriarProgramaPadrao("Feijão", "Feijão congelado", 480, 9, '%', "Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas.")
    };
    }

    private static ProgramaPadrao CriarProgramaPadrao(string nome, string alimento, int tempo, int potencia, char caractereAquecimento, string instrucoes = "")
    {
        return new ProgramaPadrao
        {
            Nome = nome,
            Alimento = alimento,
            Tempo = tempo,
            Potencia = potencia,
            Instrucoes = instrucoes,
            CaractereAquecimento = caractereAquecimento
        };
    }
}
