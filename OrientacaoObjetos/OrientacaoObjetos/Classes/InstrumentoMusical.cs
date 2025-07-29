namespace OrientacaoObjetos.Classes;

internal class Tambor : InstrumentoMusical
{
    public override void Tocar(int line)
    {
        Console.SetCursorPosition(0, line);
        Console.Write("Tambor");
        base.Esperar();
        Console.SetCursorPosition(0, line);
        Console.Write("[Tambor END]");
    }
}

internal class Violao : InstrumentoMusical
{
    public override void Tocar(int line)
    {
        Console.SetCursorPosition(0, line);
        Console.Write("Violao");
        base.Esperar();
        Console.SetCursorPosition(0, line);
        Console.Write("[Violao END]");
    }
}

internal class Piano : InstrumentoMusical
{
    public override void Tocar(int line)
    {
        Console.SetCursorPosition(0, line);
        Console.Write("Piano");
        base.Esperar();
        Console.SetCursorPosition(0, line);
        Console.Write("[Piano END]");
    }
}

internal class InstrumentoMusical
{
    public virtual void Tocar(int line)
    {
        Console.WriteLine("Nenhum som");
    }

    public void Esperar()
    {
        Thread.Sleep(800);
    }
}
