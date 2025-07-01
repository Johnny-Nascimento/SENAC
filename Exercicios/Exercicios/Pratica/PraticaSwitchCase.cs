namespace Exercicios.Pratica
{
    internal class PraticaSwitchCase
    {
        /* Versões mais recentes do .net permitem:

            int i = 63;

            switch (i)
            {
                case int n when (n >= 100):
                    Console.WriteLine($"I am 100 or above: {n}");
                    break;

                case int n when (n < 100 && n >= 50 ):
                    Console.WriteLine($"I am between 99 and 50: {n}");
                    break;

                case int n when (n < 50):
                    Console.WriteLine($"I am less than 50: {n}");
                    break;
            }
        */

        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            char inicialNome = ' ';
            if (nome.Count() != 0)
                inicialNome = nome[0];

            int numeroFila = 0;

            switch (inicialNome)
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'G':
                case 'H':
                case 'I':
                case 'J':
                    numeroFila = 2;
                    break;

                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'O':
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                    numeroFila = 1;
                    break;

                case 'T':
                case 'U':
                case 'V':
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    numeroFila = 3;
                    break;
            }

            Console.WriteLine($"O numero da sua fila é: {numeroFila}");
        }

        public static void Executar2()
        {
            while (true)
            {
                Console.WriteLine("Qual é o seu nome?");
                string nome = Console.ReadLine().ToUpper();

                if (nome == "SAIR")
                    break;

                char inicialNome = ' ';
                if (nome.Count() != 0)
                    inicialNome = nome[0];

                int numeroFila = 0;

                int asciiCode = inicialNome;

                if (asciiCode >= 65 && asciiCode <= 74)
                    numeroFila = 2;
                else if (asciiCode <= 83)
                    numeroFila = 1;
                else if (asciiCode <= 90)
                    numeroFila = 3;
                else
                    Console.WriteLine("Caractere inicial não é uma letra do alfabeto.");

                if (numeroFila != 0)
                    Console.WriteLine($"O numero da sua fila é: {numeroFila}");
            }
        }
    }
}
