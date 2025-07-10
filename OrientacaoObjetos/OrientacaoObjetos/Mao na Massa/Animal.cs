namespace OrientacaoObjetos;

public class Animal
{
    public string Nome { get; private set; }
    public string NomeCientifico { get; private set; }
    public int Idade { get; private set; }

    public Animal AdicionaNome(string nome)
    {
        Nome = nome;

        return this;
    }

    public Animal AdicionaNomeCientifico(string nomeCientifico)
    {
        NomeCientifico = nomeCientifico;

        return this;
    }

    public Animal AdicionaIdade(int idade)
    {
        Idade = idade;

        return this;
    }

    public void Morder()
    {
        Console.WriteLine($"{NomeCientifico} mordendo");
    }

    public override string ToString()
    {
        return $"{Nome} {NomeCientifico} {Idade}";
    }
}
