using PetShoes.Database.Entidades;

namespace PetShoes.Model.Pessoas
{
    public class PessoaResponseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string TipoUsuario { get; set; }

        public PessoaResponseModel() { }

        public PessoaResponseModel(Pessoa pessoa) 
        {
            Id = pessoa.Id.Value;
            Nome = pessoa.Nome;
            CPF = pessoa.CPF;
            DataNascimento = pessoa.DataNascimento;
            Email = pessoa.Email;
            Telefone = pessoa.Telefone;
            Endereco = pessoa.Endereco;
            TipoUsuario = pessoa.TipoUsuario;
        }
    }
}
