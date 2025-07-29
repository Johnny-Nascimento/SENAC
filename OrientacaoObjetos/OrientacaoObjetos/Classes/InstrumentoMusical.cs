namespace OrientacaoObjetos.Classes;

internal class Tambor : InstrumentoMusical
{
    public async override void Tocar()
    {
        Console.WriteLine("Tambor..");
        Console.Beep(37, 1000);

        Console.Write("Tambor...");
    }
}

internal class Violao : InstrumentoMusical
{
    public async override void Tocar()
    {
        Console.WriteLine("Violao..");
        Console.Beep(37, 1000);

        Console.Write("Violao...");
    }
}

internal class Piano : InstrumentoMusical
{
    public async override void Tocar()
    {
        Console.Write("Piano..");
        Console.Beep(37, 1000);

        Console.Write("Piano...");
    }
}

internal class InstrumentoMusical
{
    public async virtual void Tocar()
    {
        Console.WriteLine("Nenhum som");
    }
}
