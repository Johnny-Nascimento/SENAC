using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SystemController : Controller
    {
        [HttpGet("")]
        public bool ValidarConexao()
        {
            return PetShoes.Database.Connection.ConexaoValida();
        }
    }
}
