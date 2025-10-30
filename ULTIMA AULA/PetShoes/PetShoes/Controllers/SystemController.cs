using Microsoft.AspNetCore.Mvc;

namespace PetShoes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SystemController : Controller
    {
        [HttpGet("")]
        public bool ValidarConexao()
        {
            return PetShoes.Database.Connection.ValidarConexaoBanco();
        }
    }
}
