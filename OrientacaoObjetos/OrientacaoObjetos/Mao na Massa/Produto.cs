using System.Globalization;

namespace OrientacaoObjetos.Mao_na_Massa;

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEstoque { get; set; }

    public static string FormataValor(Produto produto, bool internacional = false)
    {
        return produto.Preco.ToString("C", new CultureInfo(internacional ? "en-US" : "pt-BR"));
    }

    public Produto(string nome, double preco) 
    {
        Nome = nome;
        Preco = preco;
    }

    public Produto(string nome, double preco, int quantidadeEstoque)
    {
        Nome = nome;
        Preco = preco;
        QuantidadeEstoque = quantidadeEstoque;
    }

    public static List<Produto> Comprar2(List<Produto> produtos, double valorPagamento, out double troco)
    {
        troco = valorPagamento;

        double valorTotalCompra = produtos.Sum(p => p.Preco);

        if (valorTotalCompra > valorPagamento)
        {
            Console.WriteLine("Você não deu dinheiro o suficiente, compra cancelada!");
            produtos.Clear();
        }
        else
            troco = valorPagamento - valorTotalCompra;

        Console.WriteLine($"Seu troco é = { troco.ToString("C2") }");

        return produtos;
    }

    public static List<Produto> Comprar(List<Produto> produtos, double valorPagamento, out double troco)
    {
        bool compraOk = true;

        double valorTotal = valorPagamento;
        troco = valorTotal;

        foreach (var item in produtos)
        {
            if (item.Preco > valorTotal)
            {
                Console.WriteLine("Você não deu dinheiro o suficiente, compra cancelada!");
                compraOk = false;
                break;
            }
            else
                Console.WriteLine($"Produto {item.Nome} passou!");

            valorTotal -= item.Preco;
        }

        if (compraOk)
            troco = valorTotal;
        else
        {
            troco = valorPagamento;
            produtos.Clear();
        }
            
        Console.WriteLine($"Troco: {troco.ToString("C2")}");

        return produtos;
    }

    public void AtualizarEstoque(int quantidade)
    {
        QuantidadeEstoque = quantidade;
    }

    public void ExibirInfo()
    {
        Console.WriteLine(String.Format("Nome {0}, Preco {1}, Quatidade estoque {2}", 
            Nome, 
            Preco, 
            QuantidadeEstoque == 0 ? "Estoque vazio" : QuantidadeEstoque ));
    }
}
