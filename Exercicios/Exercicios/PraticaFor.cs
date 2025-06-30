namespace Exercicios
{
    internal class PraticaFor
    {
        public static void Executar()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Informe um numero");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; ++i)
                Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
