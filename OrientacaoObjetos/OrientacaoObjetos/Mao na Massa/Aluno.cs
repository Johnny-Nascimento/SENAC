namespace OrientacaoObjetos.Classes;

public class Aluno
{
    private const int QUANTIDADE_MESES_NO_ANO = 12;

    private string _Nome = string.Empty;
    public string? Nome 
    {
        get
        {
            return _Nome.ToUpper();
        }

        set
        {
            if (!string.IsNullOrWhiteSpace(value)) 
            {
                _Nome = value;
            }
        }
    }

    public int Idade { get; set; }
    public string Matricula { get; set; }

    public Aluno(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Matricula = string.Empty;
    }

    public Aluno(string nome, int idade, string matricula)
    {
        Nome = nome;
        Idade = idade;
        Matricula = matricula;
    }

    public void CalcularIdadeEmMeses()
    {
        Console.WriteLine($"A idade em meses é {Idade * QUANTIDADE_MESES_NO_ANO}");
    }

    public void ExibirInfo()
    {
        Console.WriteLine(String.Format("Nome {0}, Idade {1}, Matricula {2}", 
            Nome, 
            Idade, 
            Matricula == string.Empty ? "Não matriculado" : Matricula));
    }
}
