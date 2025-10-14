using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimaisController : Controller
{
    private static List<AnimalResultModel> Animais = new List<AnimalResultModel>()
    {
        new AnimalResultModel()
        {
            Id = Guid.NewGuid(),
            Nome = "Pedrinho",
            IdadeEmMeses = 8,
            Cor = "Cinza"
        },
        new AnimalResultModel()
        {
            Id = Guid.NewGuid(),
            Nome = "Joção",
            IdadeEmMeses = 8,
            Cor = "Caramelo"
        }
    };

    [HttpGet("")]
    public IEnumerable<AnimalResultModel> GetAnimais()
    {
        return Animais;
    }

    [HttpPost("")]
    public Guid PostAnimal(AnimalRequestModel animal)
    {
        var animalAux = new AnimalResultModel()
        {
            Id = Guid.NewGuid(),
            Cor = animal.Cor,
            IdadeEmMeses = animal.IdadeEmMeses,
            Nome = animal.Nome
        };
        Animais.Add(animalAux);
        return animalAux.Id;
    }

    [HttpPut("{id}")]
    public AnimalResultModel PutAnimal(Guid id, AnimalRequestModel animal)
    {
        var animalAux = Animais.First(animal => animal.Id == id);
        animalAux.Nome = animal.Nome;
        animalAux.IdadeEmMeses = animal.IdadeEmMeses;
        animalAux.Cor = animal.Cor;
        return animalAux;
    }

    [HttpDelete("{id}")]
    public bool PutDelete(Guid id)
    {
        var animalAux = Animais.First(animal => animal.Id == id);
        Animais.Remove(animalAux);
        return true;
    }
}
