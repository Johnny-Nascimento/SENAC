namespace OrientacaoObjetos;

public class Animal
{
    public string Nome { get; set; }
    public string NomeCientifico { get; set; }
    public int Idade { get; set; }

    public void Morder()
    {
        Console.WriteLine($"{NomeCientifico} mordendo");
    }

    public override string ToString()
    {
        return $"{Nome} {NomeCientifico} {Idade}";
    }
}
