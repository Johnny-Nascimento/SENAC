using PetShoes.Database.Entidades;

namespace WebApplication1.Model;

public class AnimalResponseModel
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }
    public PorteEnum Porte { get; set; }
    public string Raca { get; set; } = string.Empty;
    public SexoEnum Sexo { get; set; }
    public bool Castrado { get; set; }
    public bool Vacinado { get; set; }
    public string Temperamento { get; set; } = string.Empty;
    public string ObservacoesMedicas { get; set; } = string.Empty;
    public StatusAdocaoEnum StatusAdocao { get; set; }
    public DateTime DataCadastro { get; set; }

    public AnimalResponseModel()
    {
    }

    public AnimalResponseModel(Animal animal)
    {
        Id = animal.Id;
        Nome = animal.Nome;
        Idade = animal.Idade;
        Porte = animal.Porte;
        Raca = animal.Raca;
        Sexo = animal.Sexo;
        Castrado = animal.Castrado;
        Vacinado = animal.Vacinado;
        Temperamento = animal.Temperamento;
        ObservacoesMedicas = animal.ObservacoesMedicas;
        StatusAdocao = animal.StatusAdocao;
        DataCadastro = animal.DataCadastro;
    }
}
