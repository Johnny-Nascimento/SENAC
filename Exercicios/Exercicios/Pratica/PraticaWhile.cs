using System.Diagnostics;

namespace Exercicios.Pratica
{
    internal class PraticaWhile
    {
        public static void Executar()
        {
            int maiorValor = int.MinValue;
            int menorValor = int.MaxValue;

            Console.WriteLine("Informe um valor");
            string entrada = Console.ReadLine();

            while (entrada.ToUpper() != "OK")
            {
                int valor = int.Parse(entrada);

                if (valor > maiorValor)
                    maiorValor = valor;

                if (valor < menorValor)
                    menorValor = valor;

                Console.WriteLine("Informe um valor");
                entrada = Console.ReadLine();
            }

            Console.WriteLine($"O maior valor informado foi {maiorValor}");
            Console.WriteLine($"O menor valor informado foi {menorValor}");
        }

        public static void Executar1()
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            int maiorValor = 0;
            int menorValor = int.MaxValue;

            for (int i = 1; i <= 1000000000; i++)
            {
                int valor = i;

                if (valor > maiorValor)
                    maiorValor = valor;

                if (valor < menorValor)
                    menorValor = valor;
            }

            Console.WriteLine($"O maior valor informado foi {maiorValor}");
            Console.WriteLine($"O menor valor informado foi {menorValor}");

            sw.Stop();

            Console.WriteLine(TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds).TotalSeconds);
        }

        public static void Executar2()
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            List<int> list = new List<int>();

            for (int i = 1; i <= 1000000000; i++)
            {
                list.Add(i);
            }

            Console.WriteLine($"O maior valor informado foi {list.Max()}");
            Console.WriteLine($"O menor valor informado foi {list.Min()}");

            sw.Stop();

            Console.WriteLine(TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds).TotalSeconds);
        }
    }
}
