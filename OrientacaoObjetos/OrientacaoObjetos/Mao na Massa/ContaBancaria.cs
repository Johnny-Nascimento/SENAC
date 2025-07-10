
namespace OrientacaoObjetos.Mao_na_Massa;

public class ContaBancaria
{
    private const decimal FATOR_PROVISIONAMENTO = 5;
    private const decimal PERCENTUAL_RENDA = 0.5m;

    private static decimal _valorTotalContas = 0;
    private static int _contagemContas = 0;

    public string  Titular { get; set; }
    public decimal Saldo { get; set; }
    public decimal Renda { get; set; }
    public bool EmprestimoAtivo { get; private set; }

    public ContaBancaria(string titular)
    {
        Titular = titular;
        Saldo = 0.00m;
        Renda = 0.0m;

        AdicionaContador();
    }

    public ContaBancaria(string titular, decimal saldo, decimal renda)
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
            _valorTotalContas += saldo;
        }

        Renda = renda >= 0 ? renda : 0;

        AdicionaContador();
    }

    private bool ProvisionamentoBanco500PorCentoMaior(decimal valor)
    {
        return _valorTotalContas >= (valor * FATOR_PROVISIONAMENTO);
    }

    private bool ValorMenorQue50PorCentoDaRenda(decimal valor)
    {
        return valor <= (Renda * PERCENTUAL_RENDA);
    }

    private static void AdicionaContador()
    {
        _contagemContas++;
    }

    public static void SaldoTotal()
    {
        Console.WriteLine($"Saldo total atual é {_valorTotalContas}");
    }

    public static void QuantidadeContas()
    {
        Console.WriteLine($"A quantidade de contas atual é {_contagemContas}");
    }

    public void Depositar(decimal valor)
    {
        if (valor < 0)
        {
            Console.WriteLine("Não foi possivel depositar");

            return;
        }

        Saldo += valor;

        _valorTotalContas += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor < 0 || valor > Saldo)
        {
            Console.WriteLine("Não foi possivel sacar");
            return;
        }

        Saldo -= valor;

        _valorTotalContas -= valor;
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
