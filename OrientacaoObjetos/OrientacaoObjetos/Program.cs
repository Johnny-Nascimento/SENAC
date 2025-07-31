using OrientacaoObjetos.Classes;
using OrientacaoObjetos.Mao_na_Massa;

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

        // Fluent
        // Animal cachorro = new Animal().
        //     AdicionaNome("Cachorro").
        //     AdicionaNomeCientifico("Cachorro cientifico").
        //     AdicionaIdade(10);

        // Console.WriteLine(cachorro.ToString());

        // Livro harryPotter = new Livro();
        // harryPotter.Titulo = "Harry Potter";
        // harryPotter.Autor = "Não sei";

        // Console.WriteLine(harryPotter.ToString());

        // Calculadora calculadora = new Calculadora();
        // Console.WriteLine(calculadora.Somar(4, 5));
        // Console.WriteLine(calculadora.Subtrair(4, 5));
        // Console.WriteLine(calculadora.Dividir(4, 5));
        // Console.WriteLine(calculadora.Multiplicar(4, 5));

        // Aluno aluno = new ("João", 20);
        // Aluno aluno2 = new ("Mario", 10, "1234XYZ");

        // aluno.CalcularIdadeEmMeses();
        // aluno.ExibirInfo();
        // aluno2.CalcularIdadeEmMeses();
        // aluno2.ExibirInfo();

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

        // var a = new ContaBancaria("Teste", 25000m, 1001m);
        // a.Emprestimo(500.00m);

        // var b = new ContaBancaria("Teste", 10.00m, 500.00m);
        // var c = new ContaBancaria("Teste", 15.00m, 0);
        // var d = new ContaBancaria("Teste", 5.00m, 100.00m);

        // ContaBancaria.QuantidadeContas();
        // ContaBancaria.SaldoTotal();

        // Produto produto = new Produto("Batata", 10.00);
        // Console.WriteLine(Produto.FormataValor(produto));
        // Console.WriteLine(Produto.FormataValor(produto, true));]

        // var b = new ContaBancaria("Teste",
        //                           10.00m,
        //                           500.00m,
        //                           PokemonInicial.Pikachu);

        // b.Emprestimo(1);

        // var a = new ContaBancaria("Teste",
        //                           10.00m,
        //                           500.00m,
        //                           PokemonInicial.Bulbassauro);

        // a.Emprestimo(1);

        // Parametro default no "meio"
        // ContaBancaria contaBancaria = new ContaBancaria("", PokemonInicial.Bulbassauro, b:5);
        // ContaBancaria contaBancariab = new ContaBancaria("", PokemonInicial.Bulbassauro, 4, 3);

        //double valorPagamento = 15;

        // V1 FOREACH
        // {
        //    List<Produto> comprasDoMes = new List<Produto>
        //    { new Produto("Batata", 2.50),
        //      new Produto("Tomate", 10.00)
        //    };

        //    var sacola = Produto.Comprar(comprasDoMes, valorPagamento, out double troco);
        //    Console.WriteLine($"Itens comprados = { sacola.Count }");
        // }

        // V2 LINQ
        // {
        //    List<Produto> comprasDoMes = new List<Produto>
        //    { new Produto("Batata", 2.50),
        //      new Produto("Tomate", 10.00)
        //    };

        //    var sacola = Produto.Comprar2(comprasDoMes, valorPagamento, out double _);
        //    Console.WriteLine($"Itens comprados = { sacola.Count }");
        // }

        // double n1 = 10;
        // double n2 = 12;
        // double n3 = 10;
        // 
        // Sistema.AlteraValores(ref n1, ref n2); // , out n3); out parte do principio de que o valor vai ser atribuido no método
        // Console.WriteLine(n1 + " " + n2 + " " + n3);

        /* 
            // Possivel erro ao tornar lista cópia
            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(new Aluno("Roberto", 10));

            List<Aluno> alunos2 = new List<Aluno>();
            alunos2.AddRange(alunos);

            alunos2[0].Nome = "XXX";
            alunos2[0].Idade = 666;

            Console.WriteLine("Aluno1");
            Console.WriteLine(alunos[0].Nome + " " + alunos[0].Idade);

            Console.WriteLine("Aluno2");
            Console.WriteLine(alunos2[0].Nome + " " + alunos2[0].Idade);
        */

        /*
        Produto produto = new Produto("Roda", 10.00);
        produto.ExibirInfo();
        Console.WriteLine("Info nome original ^^");
        produto.AlterarNome("Roda redonda");
        produto.AlterarPreco(-10.00);
        produto.ExibirInfo();
        Console.WriteLine("Tentativa e nome alterado negativo ^^");

        produto.AlterarPreco(20.00);
        produto.ExibirInfo();
        Console.WriteLine("Tentativa positivo ^^");
        */

        //Animal animal = new Animal();
        //// animal.EmitirSom();

        //Cachorro cachorro = new Cachorro();
        //// cachorro.EmitirSom();

        //Gato gato = new Gato();
        //// gato.EmitirSom();

        //List<Animal> animais = new List<Animal>();
        //animais.Add(animal);
        //animais.Add(cachorro);
        //animais.Add(gato);

        //foreach (var item in animais)
        //{
        //    item.EmitirSom();
        //}

        // Permite digitar muitas coisas no console.
        //    Console.SetBufferSize(120, 1000);

        //    Piano piano = new Piano();
        //    Violao violao = new Violao();
        //    Tambor tambor = new Tambor();

        //    int line = 0;

        //    while (true)
        //    {
        //        ConsoleKey i = Console.ReadKey(true).Key;
        //        switch (i)
        //        {
        //            case ConsoleKey.NumPad1:
        //                ExecutaInstrumento(piano, line);
        //            break;

        //            case ConsoleKey.NumPad2:
        //                ExecutaInstrumento(violao, line);
        //            break;

        //            case ConsoleKey.NumPad3:
        //                ExecutaInstrumento(tambor, line);
        //            break;

        //            case ConsoleKey.NumPad0:
        //                Thread.Sleep(800);
        //                Console.WriteLine();
        //                Console.WriteLine("Fim");
        //                return;
        //            break;
        //        }

        //        ++line;
        //    }
        //}

        //static void ExecutaInstrumento(InstrumentoMusical instrumento, int line)
        //{
        //    Console.SetCursorPosition(0, line);
        //    new Thread(() => instrumento.Tocar(line)).Start();
        //}
    }
}
