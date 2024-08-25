namespace Microondas_Digital.DAL.Models;

public class ProgramaPadrao
{
    public string Nome { get; set; } = string.Empty;
    public string Alimento { get; set; } = string.Empty;
    public int Tempo { get; set; }
    public int Potencia { get; set; }
    public char CaractereAquecimento { get; set; }
    public string? Instrucoes { get; set; }
}
