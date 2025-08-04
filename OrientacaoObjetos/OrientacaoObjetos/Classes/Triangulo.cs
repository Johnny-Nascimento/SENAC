
namespace OrientacaoObjetos.Classes;

internal class Triangulo : Forma
{
    private decimal _LadoA;
    private decimal _LadoB;
    private decimal _LadoC;

    public Triangulo(decimal ladoA, decimal ladoB, decimal ladoC)
    {
        _LadoA = ladoA;
        _LadoB = ladoB;
        _LadoC = ladoC;
    }

    protected override decimal CalcularPerimetro()
    {
        return _LadoA + _LadoB + _LadoC;
    }
}
