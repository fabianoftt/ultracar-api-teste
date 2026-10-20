using Microsoft.AspNetCore.Mvc;
using Ultracar.Application.Dtos.Request;
using Ultracar.Application.Interfaces.Oficinas;
using Ultracar.Application.Services.Oficinas;

namespace Ultracar.API.Controllers
{
    [ApiController]
    [Route("api/oficina")]
    public class OrcamentoOficinaController : ControllerBase
    {
        private readonly IGetDisgnosticoService _getDisgnosticoService;
        private readonly IGetHistoricoOficinaService _getHistoricoOficinaService;
        private readonly IGetOrcamentoOficinaService _getOrcamentoOficinaService;
        private readonly IGetVeiculoService _getVeiculoService;
        private readonly IPostEnvioOficinaService _postEnvioOficinaService;
        private readonly IPostOrcamentoService _postOrcamentoService;
        private readonly IPostRevisaoOficinaService _postRevisaoOficinaService;
        private readonly IPostSugestoesService _postSugestoesService;
        private readonly IPutItensOficinaService _putItensOficinaService;

        public OrcamentoOficinaController

            (
        IGetDisgnosticoService getDisgnosticoService,
        IGetHistoricoOficinaService getHistoricoOficinaService,
        IGetOrcamentoOficinaService getOrcamentoOficinaService,
        IGetVeiculoService getVeiculoService,
        IPostEnvioOficinaService postEnvioOficinaService,
        IPostOrcamentoService postOrcamentoService,
        IPostRevisaoOficinaService postRevisaoOficinaService,
        IPostSugestoesService postSugestoesService,
        IPutItensOficinaService putItensOficinaService
            )
        {
            _getDisgnosticoService = getDisgnosticoService;
            _getHistoricoOficinaService = getHistoricoOficinaService;
            _getOrcamentoOficinaService = getOrcamentoOficinaService;
            _getVeiculoService = getVeiculoService;
            _postEnvioOficinaService = postEnvioOficinaService;
            _postOrcamentoService = postOrcamentoService;
            _postRevisaoOficinaService = postRevisaoOficinaService;
            _postSugestoesService = postSugestoesService;
            _putItensOficinaService = putItensOficinaService;
        }

        [HttpGet("{placa}")]
        public IActionResult GetVeiculo(string placa)
        {
            return Ok();
        }

        [HttpGet("diagnosticos")]
        public IActionResult GetDisgnostico([FromQuery] string busca)
        {
            return Ok();
        }

        [HttpPost("sugestoes")]
        public IActionResult Sugestoes([FromBody] SugestaoRequest request)
        {
            return Ok();
        }

        [HttpPost("/api/v1/ordens-servico/{osId}/orcamento")]
        public IActionResult PostOrcamento(int osId)
        {
            return Created();
        }

        [HttpGet("/api/v1/orcamentos/{id}")]
        public IActionResult GetOrcamento(int id)
        {
            return Ok();
        }

        [HttpPut("/api/v1/orcamentos/{id}/itens")]
        public IActionResult PutItens(int id, [FromBody] List<ItemRequest> itens)
        {
            return Ok(new { id, itens });
        }

        [HttpPost("/api/v1/orcamentos/{id}/envio")]
        public IActionResult PostEnvio(int id)
        {
            return Ok();
        }

        [HttpPost("/api/v1/orcamentos/{id}/revisao")]
        public IActionResult PostRevisao(int id)
        {
            return Ok();
        }

        [HttpGet("/api/v1/orcamentos/{id}/historico")]
        public IActionResult GetHistorico(int id)
        {
            return Ok();
        }
    }
}

