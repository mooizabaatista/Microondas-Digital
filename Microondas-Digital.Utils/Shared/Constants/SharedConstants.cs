namespace Microondas_Digital.Utils.Shared.Constants;

public class SharedConstants
{
    public static string ConnectionString = "Server=SEU_SERVIDOR;Database=Microondas;User Id=SEU_USUARIO;Password=SUA_SENHA;TrustServerCertificate=True;";

    public static string MensagemErroCamposInvalidos = "Verifique os valores de tempo e potência.\n Tempo = 1 à 120 / Potência = 1 à 10.";

    public static string MensagemErroCaractereAquecimento = "Atenção, o caractere de aquecimento não pode se repetir com algum já cadastrado.";
}
