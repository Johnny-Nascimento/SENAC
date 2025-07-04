using OrientacaoObjetos.Classes;
using OrientacaoObjetos.Mao_na_Massa;

namespace OrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Carro uno = new Carro();
            //uno.Marca = "Fiat";
            //uno.Modelo = "Uno";
            //uno.Ano = 1999;

            //Carro fusca = new Carro();
            //fusca.Marca = "Volks";
            //fusca.Modelo = "Fusca";
            //fusca.Ano = 1990;

            //uno.Acelerar(50);
            //fusca.Acelerar(500);

            Animal coelho= new Animal();
            coelho.Nome = "Coelho";
            coelho.NomeCientifico = "Dentussus Grandes";
            coelho.Idade = 5;

            Console.WriteLine(coelho.ToString());

            Livro harryPotter = new Livro();
            harryPotter.Titulo = "Harry Potter";
            harryPotter.Autor = "Não sei";

            Console.WriteLine(harryPotter.ToString());

            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Somar(4, 5));
            Console.WriteLine(calculadora.Subtrair(4, 5));
            Console.WriteLine(calculadora.Dividir(4, 5));
            Console.WriteLine(calculadora.Multiplicar(4, 5));
        }
    }
}
