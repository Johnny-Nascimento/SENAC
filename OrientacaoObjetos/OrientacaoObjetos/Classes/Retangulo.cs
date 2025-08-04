
namespace OrientacaoObjetos.Classes;

internal class Retangulo : Forma
{
    private decimal _Comprimento;
    private decimal _Largura;

    public Retangulo(decimal comprimento, decimal largura)
    {
        _Comprimento = comprimento;
        _Largura = largura;
    }

    protected override decimal CalcularPerimetro()
    {
        return 2 * (_Comprimento + _Largura);
    }
}
