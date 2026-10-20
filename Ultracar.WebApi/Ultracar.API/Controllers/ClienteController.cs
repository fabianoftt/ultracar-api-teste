using Microsoft.AspNetCore.Mvc;

namespace Ultracar.API.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new { mensagem = "Ok Funcionando" });
        }
    }
}
