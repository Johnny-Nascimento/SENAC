using Microsoft.AspNetCore.Mvc;
using PetShoes.Database.Entidades;
using WebApplication1.Model;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimaisController : Controller
{
    [HttpGet("")]
    public IEnumerable<AnimalResponseModel> GetAll()
    {
        return Animal.GetAll().Select(i => new AnimalResponseModel(i));
    }

    //[HttpPost("")]
    //public Guid PostAnimal(AnimalRequestModel animal)
    //{
    //    var animalAux = new AnimalResultModel()
    //    {
    //        Id = Guid.NewGuid(),
    //        Cor = animal.Cor,
    //        IdadeEmMeses = animal.IdadeEmMeses,
    //        Nome = animal.Nome
    //    };
    //    Animais.Add(animalAux);
    //    return animalAux.Id;
    //}

    //[HttpPut("{id}")]
    //public AnimalResultModel PutAnimal(Guid id, AnimalRequestModel animal)
    //{
    //    var animalAux = Animais.First(animal => animal.Id == id);
    //    animalAux.Nome = animal.Nome;
    //    animalAux.IdadeEmMeses = animal.IdadeEmMeses;
    //    animalAux.Cor = animal.Cor;
    //    return animalAux;
    //}

    //[HttpDelete("{id}")]
    //public bool PutDelete(Guid id)
    //{
    //    var animalAux = Animais.First(animal => animal.Id == id);
    //    Animais.Remove(animalAux);
    //    return true;
    //}
}
