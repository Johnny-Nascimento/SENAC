using NASA.DB;

namespace NASA.ACOES;

internal class Program
{
    static void Main(string[] args)
    {
        // Seed inicial
        new AstronautaDB();

        // Chama Aplicação
        Menu.Mostrar();
    }
}
