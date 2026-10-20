using Microsoft.AspNetCore.Mvc;

namespace Ultracar.API.Controllers
{
    [ApiController]
    [Route("api/oficina")]
    public class OficinaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new { mensagem = "Ok Funcionando" });
        }
    }
}
