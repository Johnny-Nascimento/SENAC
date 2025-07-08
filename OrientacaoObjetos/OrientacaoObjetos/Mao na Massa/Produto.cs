using System.Globalization;

namespace OrientacaoObjetos.Mao_na_Massa;

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEstoque { get; set; }

    public static string FormataValor(Produto produto, bool internacional = false)
    {
        if (internacional)
            return produto.Preco.ToString("C", new CultureInfo("en-US"));
        else
            return produto.Preco.ToString("C");
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
