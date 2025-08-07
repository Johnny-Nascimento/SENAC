namespace OrientacaoObjetos;

public interface IAutenticavel
{
    string User { get; set; }
    string Password { get; set; }

    void Autenticar();
    void Deslogar();
}
