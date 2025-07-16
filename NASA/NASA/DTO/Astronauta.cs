namespace NASA.DTO;

public class Astronauta
{
    public string Nome { get; }
    public DateOnly DataNascimento { get; }
    public string PaisOrigem { get; }

    public Astronauta(string nome, DateOnly data, string paisOrigem)
    {
        Nome = nome;
        DataNascimento = data;
        PaisOrigem = paisOrigem;
    }

    public override string ToString()
    {
        return $"{Nome} {DataNascimento.ToString()} {PaisOrigem}";
    }
}
