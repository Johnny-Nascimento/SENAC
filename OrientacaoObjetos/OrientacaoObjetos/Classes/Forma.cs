
namespace OrientacaoObjetos.Classes;

internal abstract class Forma
{
    protected abstract decimal CalcularPerimetro();
    public void MostraPerimetro()
    {
        string forma = GetType().Name;
        decimal perimetro = CalcularPerimetro();
        Console.WriteLine($"O perimetro do {forma} é {perimetro.ToString()}");
    }
}
