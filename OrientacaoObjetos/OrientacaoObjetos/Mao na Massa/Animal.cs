namespace OrientacaoObjetos;

public class Animal
{
    public string Nome { get; private set; } = string.Empty;
    public string NomeCientifico { get; private set; } = string.Empty;
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

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }

    public override string ToString()
    {
        return $"{Nome} {NomeCientifico} {Idade}";
    }
}
