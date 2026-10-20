using Microsoft.AspNetCore.Mvc;
using Ultracar.Application.Clientes;

namespace Ultracar.API.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new { mensagem = "Ok Funcionando" });
        }
    }
}
