namespace WebApplication1.Model;

public class AdotantesResultModel
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }
}

public class AdotantesRequestModel
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }
}
