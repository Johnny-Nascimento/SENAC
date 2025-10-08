namespace WebApplication1.Model;

public class AnimalResultModel
{
    public Guid Id { get; set; }
    public string Cor { get; set; }
    public int IdadeEmMeses { get; set; }
    public string Nome { get; set; }
}

public class AnimalRequestModel
{
    public string Cor { get; set; }
    public int IdadeEmMeses { get; set; }
    public string Nome { get; set; }
}
