using Microsoft.AspNetCore.Mvc;
using PetShoes.Database.Entidades;
using PetShoes.Model.Animais;

namespace PetShoes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimaisController : Controller
    {
        [HttpGet("")]
        public IEnumerable<AnimalResponseModel> GetAnimais()
        {
            return Animal.GetAll().Select(animal => new AnimalResponseModel(animal));
        }

        [HttpGet("{id}")]
        public AnimalResponseModel GetAnimais(int id)
        {
            return new AnimalResponseModel(Animal.Get(id));
        }

        [HttpPost("")]
        public int PostAnimais(AnimalRequestModel animalRequest)
        {
            var animal = animalRequest.GetEntidade();
            animal.Save();

            return animal.Id.Value;
        }

        [HttpPut("{id}")]
        public AnimalResponseModel PutAnimal(int id, AnimalRequestModel animalRequest)
        {
            var animal = Animal.Get(id);
            if (animal == null)
            {
                throw new Exception("Animal não existe!");
            }
            else
            {
                animal.Nome = animalRequest.Nome;
                animal.Idade = animalRequest.Idade;
                animal.Porte = animalRequest.Porte;
                animal.Raca = animalRequest.Raca;
                animal.Sexo = animalRequest.Sexo;
                animal.Castrado = animalRequest.Castrado;
                animal.Vacinado = animalRequest.Vacinado;
                animal.Temperamento = animalRequest.Temperamento;
                animal.ObservacoesMedicas = animalRequest.ObservacoesMedicas;
                animal.Status = animalRequest.Status;

                animal.Save();
                return new AnimalResponseModel(animal);
            }
        }

        [HttpDelete("{id}")]
        public bool DeleteAnimal(int id)
        {
            var animal = Animal.Get(id);
            if (animal == null)
            {
                throw new Exception("Animal não existe!");
                //return false;
            }
            else
            {
                animal.Delete();
                return true;
            }
        }
    }
}