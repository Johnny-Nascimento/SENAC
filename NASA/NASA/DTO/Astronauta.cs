namespace NASA.DTO;

public class Astronauta
{
    public string Nome { get; set; }
    public DateOnly DataNascimento { get; set; }
    public string PaisOrigem { get; set; }

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
