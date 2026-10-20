using Microsoft.AspNetCore.Mvc;
using Ultracar.Application.Dtos.Request;
using Ultracar.Application.Interfaces.Cliente;
using Ultracar.Application.Services.Clientes;

namespace Ultracar.API.Controllers
{
    [ApiController]
    [Route("public/v1/orcamentos")]
    public class OrcamentoClienteController : Controller
    {
        private readonly IGetOrcamentoClienteService _getOrcamentoClienteService;
        private readonly IPostOrcamentoClienteService _postOrcamentoClienteService;

        public OrcamentoClienteController
            (
            IGetOrcamentoClienteService getOrcamentoClienteService,
            IPostOrcamentoClienteService postOrcamentoClienteService
            )
        {
            _getOrcamentoClienteService = getOrcamentoClienteService;
            _postOrcamentoClienteService = postOrcamentoClienteService;
        }

        [HttpGet("{token}")]
        public IActionResult GetOrcamento(string token)
        {
            return Ok();
        }

        [HttpPost("{token}/decisao")]
        public IActionResult PostDecisao(string token, [FromBody] DecisaoRequest request)
        {

            return Ok();
        }
    }
}
