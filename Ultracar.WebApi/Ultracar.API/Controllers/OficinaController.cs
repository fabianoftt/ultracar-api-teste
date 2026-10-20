using Microsoft.AspNetCore.Mvc;
using Ultracar.Application.Dtos.Request;
using Ultracar.Application.Services.Oficinas;

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

        [HttpGet("{placa}")]
        public IActionResult ObterVeiculo(string placa)
        {
            return Ok();
        }

        [HttpGet("diagnosticos")]
        public IActionResult ObterDisgnostico([FromQuery] string busca)
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

