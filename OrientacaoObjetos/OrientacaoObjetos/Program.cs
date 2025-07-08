using OrientacaoObjetos.Classes;
using OrientacaoObjetos.Mao_na_Massa;
using System.Diagnostics.Metrics;

namespace OrientacaoObjetos;

internal class Program
{
    static void Main(string[] args)
    {
        // Carro uno = new Carro();
        // uno.Marca = "Fiat";
        // uno.Modelo = "Uno";
        // uno.Ano = 1999;

        // Carro fusca = new Carro();
        // fusca.Marca = "Volks";
        // fusca.Modelo = "Fusca";
        // fusca.Ano = 1990;

        // uno.Acelerar(50);
        // fusca.Acelerar(500);

        // Animal coelho= new Animal();
        // coelho.Nome = "Coelho";
        // coelho.NomeCientifico = "Dentussus Grandes";
        // coelho.Idade = 5;

        // coelho.Morder();

        // Console.WriteLine(coelho.ToString());

        // Livro harryPotter = new Livro();
        // harryPotter.Titulo = "Harry Potter";
        // harryPotter.Autor = "Não sei";

        // Console.WriteLine(harryPotter.ToString());

        // Calculadora calculadora = new Calculadora();
        // Console.WriteLine(calculadora.Somar(4, 5));
        // Console.WriteLine(calculadora.Subtrair(4, 5));
        // Console.WriteLine(calculadora.Dividir(4, 5));
        // Console.WriteLine(calculadora.Multiplicar(4, 5));

        // Aluno aluno = new ("João", 50);
        // Aluno aluno2 = new ("Mario", 10, "1234XYZ");
        // 
        // aluno.CalcularIdadeEmMeses();
        // aluno.ExibirInfo();
        // aluno2.ExibirInfo();
        // aluno2.CalcularIdadeEmMeses();
        // 
        // ContaBancaria conta = new ("Jorge");
        // conta.Sacar(10);
        // conta.ExibirSaldo();
        // conta.Depositar(10);
        // conta.ExibirSaldo();
        // conta.Sacar(10);
        // conta.ExibirSaldo();
        
        // ContaBancaria conta2 = new ("Maicon", 10.00m);
        // conta2.Sacar(10);
        // conta2.ExibirSaldo();
        // conta2.Depositar(10);
        // conta2.ExibirSaldo();
        // conta2.Sacar(10);
        // conta2.ExibirSaldo();

    /*
     Emprestimo
        Pra pegar precisa ter 500% do valor em conta
        Valor do emprestimo não deve ser 50% maior que a rendaRenda declarada 
        Não pode ter emprestimo ativo
    */

        var a = new ContaBancaria("Teste", 25000m, 1001m);
        a.Emprestimo(500.00m);

        // var b = new ContaBancaria("Teste", 10.00m, 500.00m);
        // var c = new ContaBancaria("Teste", 15.00m, 0);
        // var d = new ContaBancaria("Teste", 5.00m, 100.00m);

        ContaBancaria.QuantidadeContas();
        ContaBancaria.SaldoTotal();

        // Produto produto = new Produto("Batata", 10.00);
        // Console.WriteLine(Produto.FormataValor(produto));
        // Console.WriteLine(Produto.FormataValor(produto, true));
    }
}
