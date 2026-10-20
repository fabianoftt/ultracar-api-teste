using Microsoft.AspNetCore.Mvc;
using Ultracar.Application.Oficinas;

namespace Ultracar.API.Controllers
{
    [ApiController]
    [Route("api/oficina")]
    public class OficinaController : ControllerBase
    {
        private readonly IOficinaService _oficinaService;

        public OficinaController(IOficinaService oficinaService)
        {
            _oficinaService = oficinaService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new { mensagem = "Ok Funcionando" });
        }
    }
}
