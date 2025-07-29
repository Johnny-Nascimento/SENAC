namespace OrientacaoObjetos.Classes;

internal class Tambor : InstrumentoMusical
{
    public override void Tocar()
    {
        Console.Write("Tambor");
        base.Esperar();
        Console.Write("Tambor Fim");
    }
}

internal class Violao : InstrumentoMusical
{
    public override void Tocar()
    {
        Console.Write("Violao");
        base.Esperar();
        Console.Write("Violao Fim");
    }
}

internal class Piano : InstrumentoMusical
{
    public override void Tocar()
    {
        Console.Write("Piano");
        base.Esperar();
        Console.Write("Piano Fim");
    }
}

internal class InstrumentoMusical
{
    public virtual void Tocar()
    {
        Console.WriteLine("Nenhum som");
    }

    public void Esperar()
    {
        Thread.Sleep(800);
        Console.Write(".");
        Thread.Sleep(800);
        Console.Write(".");
        Thread.Sleep(800);
        Console.Write(".");
    }
}
