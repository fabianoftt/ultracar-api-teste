using Microsoft.AspNetCore.Mvc;
using Ultracar.Application.Dtos.Request;
using Ultracar.Application.Interfaces.Cliente;

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
        public async Task<IActionResult> GetOrcamento(string token)
        {
            var listaOrcamento = _getOrcamentoClienteService.ObterOrcamentoClienteService(token);
            return Ok(listaOrcamento);
        }

        [HttpPost("{token}/decisao")]
        public async Task<IActionResult> PostDecisao(string token, [FromBody] DecisaoRequest request)
        {
            var listaOrcamento = _postOrcamentoClienteService.SalvarDecisaoOrcamentoClienteService(request);
            return Ok();
        }
    }
}
