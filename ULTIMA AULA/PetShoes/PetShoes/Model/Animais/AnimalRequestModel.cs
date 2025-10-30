using PetShoes.Database.Entidades;

namespace PetShoes.Model.Animais
{
    public class AnimalRequestModel
    {
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

        public Animal GetEntidade()
        {
            return new Animal
            {
                Nome = Nome,
                Idade = Idade,
                Porte = Porte,
                Raca = Raca,
                Sexo = Sexo,
                Castrado = Castrado,
                Vacinado = Vacinado,
                Temperamento = Temperamento,
                ObservacoesMedicas = ObservacoesMedicas,
                Status = Status,
            };
        }
    }
}