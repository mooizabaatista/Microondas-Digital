namespace Microondas_Digital.Utils.Shared.Exceptions;

public class CampoInvalidoException : Exception
{
    public CampoInvalidoException(string message)
        : base($"{message}")
    {
    }
}

public class ValorInvalidoException : Exception
{
    public ValorInvalidoException(string campo, int min, int max)
        : base($"O campo '{campo}' deve ser entre {min} e {max}.")
    {
    }
}


