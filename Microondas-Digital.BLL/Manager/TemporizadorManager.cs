namespace Microondas_Digital.BLL.Manager;

public class TemporizadorManager
{
    public int Tempo { get; set; }
    public int Potencia { get; set; }
    public bool ContinuaRodando { get; set; }
    public bool IsLigado { get; private set; }
    public bool IsPausado { get; private set; }

    public TemporizadorManager()
    {
        Tempo = 30;
        Potencia = 10;
    }

    public bool ValidarTempo(string tempo, string potencia)
    {
        bool isValid = true;

        int.TryParse(tempo, out var resultTempo);
        int.TryParse(potencia, out var resultPotencia);

        if (resultTempo < 0 || resultTempo > 120)
        {
            isValid = false;
        }

        if (resultPotencia < 0 || resultPotencia > 10)
        {
            isValid = false;
        }

        return isValid;
    }

    public bool ValidarPotencia()
    {
        return Potencia >= 1 && Potencia <= 10;
    }

    public void Iniciar()
    {
        IsLigado = true;
        IsPausado = false;
        ContinuaRodando = true;
    }

    public void Pausar()
    {
        if (IsLigado)
        {
            IsLigado = false;
            IsPausado = true;
            ContinuaRodando = false;
        }
    }

    public void Cancelar()
    {
        Tempo = 0;
        Potencia = 0;
        ContinuaRodando = false;
        IsLigado = false;
        IsPausado = false;
    }

    public void AdicionarTempo(int? tempoAtual)
    {
        if (tempoAtual.HasValue)
            Tempo = Math.Min(tempoAtual.Value + 30, 120);
    }

    public void DecrementarTempo()
    {
        if (Tempo > 0)
            Tempo--;
    }

    public void Finalizar()
    {
        ContinuaRodando = false;
        IsLigado = false;
    }

    public void Resetar()
    {
        Tempo = 30;
        Potencia = 10;
    }

    public string ConverteSegundosMinutos(int tempo)
    {
        var minutos = tempo / 60;
        var segundos = tempo % 60;

        return $"{minutos:D2}:{segundos:D2}";
    }
}
