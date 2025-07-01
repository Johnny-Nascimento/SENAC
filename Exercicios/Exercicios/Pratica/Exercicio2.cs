using System;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Exercicios.Pratica
{
    public class InstrucaoIf
    {
        // Escreva um programa que peça para o usuário um número.
        // O programa deve informar ao usuário se o número é ímpar ou par.
        public static void Exercicio1()
        {
            Console.WriteLine("Escreva um número");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");
        }

        // Escreva um programa que peça ao usuário o nome e a idade.
        // Caso o usuário seja menor de idade ou sua idade seja superior a 60 anos,
        // o programa deve indicar que sua entrada será barrada por normas de segurança.
        public static void Exercicio2()
        {
            Console.WriteLine("Escreva sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18 || idade >= 60)
                Console.WriteLine("Entrada barrada");
            else
                Console.WriteLine("Bem vindo");
        }
    }

    public class InstrucaoSwitch
    {
        enum DiaSemana
        {
            Domingo = 1,
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        }

        // Escreva um programa que peça ao usuário um número de 1 a 7 e após isso,
        // retorne o dia da semana correspondente a esse número.
        // Exemplo: 1 == “Domingo”. 7 == “Sábado”.
        public static void Exercicio1()
        {
            Console.WriteLine("Informe um número de 1 a 7");
            DiaSemana semanaNumero = (DiaSemana)int.Parse(Console.ReadLine());

            switch (semanaNumero)
            {
                case DiaSemana.Domingo:
                    Console.WriteLine("Domingo");
                    break;
                case DiaSemana.Segunda:
                    Console.WriteLine("Segunda");
                    break;
                case DiaSemana.Terca:
                    Console.WriteLine("Terça");
                    break;
                case DiaSemana.Quarta:
                    Console.WriteLine("Quarta");
                    break;
                case DiaSemana.Quinta:
                    Console.WriteLine("Quinta");
                    break;
                case DiaSemana.Sexta:
                    Console.WriteLine("Sexta");
                    break;
                case DiaSemana.Sabado:
                    Console.WriteLine("Sabado");
                    break;

                default:
                    Console.WriteLine("Numero não esta no intervalo de 1 a 7");
                    break;
            }

        }
    }

    public class InstrucaoArray
    {
        // Escreva um programa que peça ao usuário 5 valores numéricos e
        // armazene-os em um Array.
        // Calcule a soma de todos esses números e exiba o resultado na tela.

        public static void Exercicio1()
        {
            int[] valores = new int[5];

            Console.WriteLine("Informe um valor");
            valores[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor");
            valores[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor");
            valores[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor");
            valores[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor");
            valores[4] = int.Parse(Console.ReadLine());

            Console.Write("O resultado da soma de todos os valores é: ");
            var resultado = valores[0] + valores[1] + valores[2] + valores[3]
                + valores[4];
            Console.WriteLine(resultado);
        }

        // Escreva um programa que peça ao usuário 10 números e armazene-os em um Array.
        // O programa deve identificar o maior e o menor número informado pelo usuário.
        public static void Exercicio2()
        {
            int[] valores = new int[10];

            int maiorValor = 0;
            int menorValor = int.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um valor");
                valores[i] = int.Parse(Console.ReadLine());

                if (valores[i] > maiorValor)
                    maiorValor = valores[i];

                if (valores[i] < menorValor)
                    menorValor = valores[i];
            }

            Console.WriteLine($"O maior valor informado foi {maiorValor}");
            Console.WriteLine($"O menor valor informado foi {menorValor}");
        }


        // Escreva um programa que peça ao usuário 5 nomes e armazene-os em um Array.
        // Após isso exiba os nomes na ordem inversa da qual foram inseridos.
        public static void Exercicio3()
        {
            string[] nomes = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe um nome");
                nomes[i] = Console.ReadLine();
            }

            for (int i = 4; i >= 0; --i)
                Console.WriteLine(nomes[i]);
        }
    }


    public class Listas
    {
        // Escreva um programa que peça ao usuário uma quantidade indeterminada de nomes.
        // Ao final da execução, exiba todos os nomes informados pelo usuário
        // (Sinta-se à vontade para definir o gatilho desejado para encerrar a coleta de nomes).
        public static void Exercicio1()
        {
            List<string> nomes = new List<string>();
            string nome = "";

            Console.WriteLine("Informe o nome (informe sair para sair)");
            nome = Console.ReadLine();

            while (nome.ToUpper() != "SAIR")
            {
                nomes.Add(nome);

                Console.WriteLine("Informe o nome (informe sair para sair)");
                nome = Console.ReadLine();
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine(String.Join('\n', nomes));
        }

        // Escreva um programa que possua uma lista com 10 número de sua preferência,
        // os quais devem estar entre 1 e 100.
        // Peça para o usuário informar um número de 1 a 100 e
        // após isso verifique se o número está presente na lista criada inicialmente.
        // Dê três chances para o usuário acertar o máximo de números.
        public static void Exercicio2()
        {
            List<int> numeros = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int numeroAleatorio = rnd.Next(1, 100);

                if (numeros.FirstOrDefault(n => n == numeroAleatorio) == 0)
                    numeros.Add(numeroAleatorio);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Informe um numero");
                int numeroEscolhido = int.Parse(Console.ReadLine());

                if (numeros.FirstOrDefault(n => n == numeroEscolhido) != 0)
                    Console.WriteLine("Acertou");
                else
                    Console.WriteLine("Errou tente novamente");
            }
        }
    }

    public class InstrucaoFor
    {
        // Escreva um programa que peça ao usuário um número inteiro positivo
        // e calcule o fatorial desse número usando um loop for.
        // Por exemplo: 5! = 5×4×3×2×1=120. 3! = 3×2×1=6. 0! = 1 (por definição).
        public static void Exercicio1()
        {
            Console.WriteLine("Informe um numero");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("Resultado é 1");
                return;
            }


            int resultado = 0;
            for (int i = numero; i >= 1; --i)
            {
                if (numero - 1 != 0)
                    resultado += numero * numero - 1;
            }

            Console.WriteLine("Resultado é " + resultado);
        }

        // Escreva um programa que peça ao usuário um número
        // e exiba a tabuada desse número para o usuário.
        public static void Exercicio2()
        {
            Console.WriteLine("Informe um numero");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; ++i)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }

    public class InstrucaoWhile
    {
        // Escreva um programa que permita ao usuário inserir números indefinidamente
        // até que um número negativo seja inserido.
        // O programa deve calcular e exibir a soma de todos os números positivos inseridos.
        public static void Exercicio1()
        {
            List<int> valores = new List<int>();

            Console.WriteLine("Informe um número (informe um valor negativo para parar)");
            int valor = int.Parse(Console.ReadLine());

            while (valor >= 0)
            {
                valores.Add(valor);

                Console.WriteLine("Informe um número (informe um valor negativo para parar)");
                valor = int.Parse(Console.ReadLine());
            }

            var resultado = valores.Sum();

            Console.WriteLine("Resultado: " + resultado);
        }

        public static void Exercicio2()
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Informe um número (informe 0 para parar)");
            int numero = int.Parse(Console.ReadLine());

            var contadorNumerosPares = 0;
            while (numero != 0)
            {
                if (numero % 2 == 0)
                    ++contadorNumerosPares;

                numeros.Add(numero);

                Console.WriteLine("Informe um número (informe 0 para parar)");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numeros Pares: " + contadorNumerosPares);
        }
    }

    public class InstrucaoForeach
    {
        // Escreva um programa que declare uma lista com 5 nomes e exiba-os em tela.
        public static void Exercicio1()
        {
            List<string> nomes = new List<string>()
            { "Marco1", "Marco2", "Marco3", "Marco4", "Marco5" };

            foreach (var nome in nomes)
                Console.WriteLine(nome);
        }
    }

    public class InstrucaoDoWhile
    {
        enum opcoesMenu
        {
            ConsultaSaldo = 1,
            Deposito,
            RealizarSaque,
            Sair
        }

        public static void Exercicio1()
        {
            opcoesMenu opcao;
            double SaldoConta = 0;

            do
            {
                Console.WriteLine("1 - Consultar saldo");
                Console.WriteLine("2 - Realizar deposito");
                Console.WriteLine("3 - Realizar saque");
                Console.WriteLine("4 - Sair");

                opcao = (opcoesMenu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case opcoesMenu.ConsultaSaldo:
                        Console.WriteLine("Saldo: " + SaldoConta);
                        break;

                    case opcoesMenu.Deposito:
                        Console.WriteLine("Informe o valor: ");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        SaldoConta += valorDeposito;
                        break;

                    case opcoesMenu.RealizarSaque:
                        Console.WriteLine("Informe o valor: ");
                        double valorSaque = double.Parse(Console.ReadLine());
                        SaldoConta -= valorSaque;
                        break;

                    case opcoesMenu.Sair:
                        break;

                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
            }
            while (opcao != opcoesMenu.Sair);
        }
    }
}
