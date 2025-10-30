using PetShoes.Database.Entidades;

namespace PetShoes.Model.Pessoas
{
    public class PessoaRequestModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string TipoUsuario { get; set; }

        public Pessoa GetEntidade()
        {
            return new Pessoa
            {
                Nome = Nome,
                CPF = CPF,
                DataNascimento = DataNascimento,
                Email = Email,
                Telefone = Telefone,
                Endereco = Endereco,
                TipoUsuario = TipoUsuario
            };
        }
    }
}
