using Microsoft.AspNetCore.Mvc;
using PetShoes.Database.Entidades;
using PetShoes.Model.Pessoas;
using System.Linq;

namespace PetShoes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : Controller
    {
        
        [HttpGet("")]
        public IEnumerable<PessoaResponseModel> GetPessoas()
        {
            return Pessoa.GetAll().Select(pessoa => new PessoaResponseModel(pessoa));
        }

        [HttpGet("{id}")]
        public PessoaResponseModel GetAnimais(int id)
        {
            return new PessoaResponseModel(Pessoa.Get(id));
        }

        [HttpPost("")]
        public int PostAnimais(PessoaRequestModel pessoaRequest)
        {
            var pessoa = pessoaRequest.GetEntidade();
            pessoa.Save();

            return pessoa.Id.Value;
        }

        [HttpPut("{id}")]
        public PessoaResponseModel PutAnimal(int id, PessoaResponseModel pessoaRequest)
        {
            var pessoa = Pessoa.Get(id);
            if (pessoa == null)
            {
                throw new Exception("Animal não existe!");
            }
            else
            {
                pessoa.Nome = pessoaRequest.Nome;
                pessoa.CPF = pessoaRequest.CPF;
                pessoa.DataNascimento = pessoaRequest.DataNascimento;
                pessoa.Email = pessoaRequest.Email;
                pessoa.Telefone = pessoaRequest.Telefone;
                pessoa.Endereco = pessoaRequest.Endereco;
                pessoa.TipoUsuario = pessoaRequest.TipoUsuario;

                pessoa.Save();
                return new PessoaResponseModel(pessoa);
            }
        }

        [HttpDelete("{id}")]
        public bool DeletePessoa(int id)
        {
            var pessoa = Pessoa.Get(id);
            if (pessoa == null)
            {
                throw new Exception("Animal não existe!");
            }
            else
            {
                pessoa.Delete();
                return true;
            }
        }
    }
}
