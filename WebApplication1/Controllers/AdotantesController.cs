using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class AdotantesController : Controller
{
    private static List<AdotantesResultModel> Adotantes = new List<AdotantesResultModel>()
{
    new AdotantesResultModel()
    {
        Id = Guid.NewGuid(),
        Nome = "Pedrinho",
        DataNascimento = DateTime.Now,
        CPF = "99999999999"
    },
    new AdotantesResultModel()
    {
        Id = Guid.NewGuid(),
        Nome = "Pedrão",
        DataNascimento = DateTime.Now,
        CPF = "99999999999"
    }
};

    [HttpGet("")]
    public IEnumerable<AdotantesResultModel> GetAdotantes()
    {
        return Adotantes;
    }

    [HttpPost("")]
    public Guid PostAdotante(AdotantesRequestModel adotante)
    {
        var adotanteAux = new AdotantesResultModel()
        {
            Id = Guid.NewGuid(),
            Nome = adotante.Nome,
            DataNascimento = adotante.DataNascimento,
            CPF = adotante.CPF
        };

        Adotantes.Add(adotanteAux);

        return adotanteAux.Id;
    }

    [HttpPut("{id}")]
    public AdotantesResultModel PutAdotante(Guid id, AdotantesRequestModel adotante)
    {
        var adotanteAux = Adotantes.First(adotante => adotante.Id == id);
        adotanteAux.Nome = adotante.Nome;
        adotanteAux.DataNascimento = adotante.DataNascimento;
        adotanteAux.CPF = adotante.CPF;

        return adotanteAux;
    }

    [HttpDelete("{id}")]
    public bool PutDelete(Guid id)
    {
        var adotanteAux = Adotantes.First(adotante => adotante.Id == id);
        Adotantes.Remove(adotanteAux);

        return true;
    }
}
