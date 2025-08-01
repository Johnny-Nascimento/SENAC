﻿namespace OrientacaoObjetos.Mao_na_Massa;

public class ContaBancaria
{
    private const decimal FATOR_PROVISIONAMENTO = 5;
    private const decimal PERCENTUAL_RENDA = 0.5m;

    private static decimal _ValorTotalContas = 0;
    private static int _ContagemContas = 0;

    public string  Titular { get; set; }
    public decimal Saldo { get; set; }
    public decimal Renda { get; set; }
    public bool EmprestimoAtivo { get; private set; }
    public PokemonInicial PokemonInicial { get; set; }

    public ContaBancaria(string titular, PokemonInicial pokemonInicial, int a = 1, int b = 2)
    {
        Console.WriteLine(a + " " +  b);

        Titular = titular;
        Saldo = 0.00m;
        Renda = 0.0m;
        PokemonInicial = pokemonInicial;

        AdicionaContador();
    }

    public ContaBancaria(string titular, decimal saldo, decimal renda, PokemonInicial pokemonInicial)
    {
        Titular = titular;

        if (saldo < 0)
        {
            Console.WriteLine("Tentativa de inicializar com valor negativo, o saldo será inicializado com 0");
            Saldo = 0;
        }
        else
        {
            Saldo = saldo;
            _ValorTotalContas += saldo;
        }

        Renda = renda >= 0 ? renda : 0;

        AdicionaContador();
        PokemonInicial = pokemonInicial;
    }

    private bool ProvisionamentoBanco500PorCentoMaior(decimal valor)
    {
        return _ValorTotalContas >= (valor * FATOR_PROVISIONAMENTO);
    }

    private bool ValorMenorQue50PorCentoDaRenda(decimal valor)
    {
        return valor <= (Renda * PERCENTUAL_RENDA);
    }

    private static void AdicionaContador()
    {
        _ContagemContas++;
    }

    public static void SaldoTotal()
    {
        Console.WriteLine($"Saldo total atual é {_ValorTotalContas}");
    }

    public static void QuantidadeContas()
    {
        Console.WriteLine($"A quantidade de contas atual é {_ContagemContas}");
    }

    public void Depositar(decimal valor)
    {
        if (valor < 0)
        {
            Console.WriteLine("Não foi possivel depositar");

            return;
        }

        Saldo += valor;

        _ValorTotalContas += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor < 0 || valor > Saldo)
        {
            Console.WriteLine("Não foi possivel sacar");
            return;
        }

        Saldo -= valor;

        _ValorTotalContas -= valor;
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo {Saldo}");
    }

    /*
     Emprestimo
        Não pode ter emprestimo ativo
        Pra pegar o banco precisa ter 500% do valor em conta
        Valor do emprestimo não deve ser 50% maior que a rendaRenda declarada 
    */
    public void Emprestimo(decimal valor)
    {
        if (PokemonInicial == PokemonInicial.Bulbassauro)
        {
            Console.WriteLine($"Você não merece por sua escolha de {PokemonInicial.ToString()}");
            return;
        }

        if (valor <= 0)
        {
            Console.WriteLine("Valor de emprestimo inválido!");
            return;
        }

        if (!EmprestimoAtivo
          && ProvisionamentoBanco500PorCentoMaior(valor)
          && ValorMenorQue50PorCentoDaRenda(valor)
           )
        {
            Saldo += valor;

            EmprestimoAtivo = true;

            Console.WriteLine("Emprestimo realizado com sucesso!");
        }
        else
            Console.WriteLine("Emprestimo negado!");
    }
}
