using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class PraticaIfElse
    {
        public static void Executar()
        {
            Console.WriteLine("Escreva seu nome");
            string nome = Console.ReadLine();

            var nomeMaiusculo = nome?.ToUpper();

            if (nomeMaiusculo == "ANA"
                || nomeMaiusculo == "MARIA"
                || nomeMaiusculo == "JOÃO"
                || nomeMaiusculo == "JOSÉ"
                || nomeMaiusculo == "CARLOS")
            {
                Console.WriteLine($"Pode entrar {nome}");
            }
            else
            {
                Console.Write($"Desculpe {nome} ");
                Console.Write("mas seu nome não está na lista.");
                Console.WriteLine();
            }
        }

        public static void Execuar2()
        {
            PraticaIfElse.Executar();

            List<string> convidados = new List<string>
            { "ANA"
            , "MARIA"
            , "JOÃO"
            , "JOAO"
            , "CARLOS"};

            Console.WriteLine("Escreva seu nome");
            string nome = Console.ReadLine();

            if (convidados.FirstOrDefault(n => n == nome?.ToUpper())
                != null)
                Console.WriteLine($"Pode entrar {nome}");
            else
            {
                Console.Write($"Desculpe {nome} ");
                Console.Write("mas seu nome não está na lista.");
                Console.WriteLine();
            }
        }
    }
}
