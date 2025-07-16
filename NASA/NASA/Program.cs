using NASA.DB;

namespace NASA.ACOES;

internal class Program
{
    static void Main(string[] args)
    {
        // Seed inicial
        AstronautaDB.CarregaDadosIniciais();

        // Chama Aplicação
        Menu.Mostrar();
    }
}
