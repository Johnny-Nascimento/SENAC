using System.Security.Cryptography;
using System.Text;

namespace OrientacaoObjetos;

public class UsuarioSistema : IAutenticavel
{
    private string password = string.Empty;

    private const string ADMIN_USER = "Admin";
    private const string ADMIN_PASSWORD = "Admin";

    public string User { get; set; } = string.Empty;
    public string Password { get => password; set => password = GeraHash(value); }

    private string GeraHash(string texto)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            var bytes = Encoding.UTF8.GetBytes(texto);
            var hashBytes = sha256.ComputeHash(bytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
        }
    }

    public void Autenticar()
    {
        if (User == ADMIN_USER && Password == GeraHash(ADMIN_PASSWORD))
            Console.WriteLine("Logou");
        else
            Console.WriteLine("Usuario ou senha inválidos.");
    }

    public void Deslogar()
    {
        User = string.Empty;
        Password = string.Empty;

        Console.WriteLine("Deslogou");
    }
}
