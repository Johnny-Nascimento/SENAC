using PetShoes.Database.Entidades;

namespace PetShoes.Model.Animais
{
    public class AnimalResponseModel
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Porte { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public bool Castrado { get; set; }
        public bool Vacinado { get; set; }
        public string Temperamento { get; set; }
        public string ObservacoesMedicas { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public AnimalResponseModel() { }

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
            Status = animal.Status;
            DataCadastro = animal.DataCadastro;
        }
    }
}