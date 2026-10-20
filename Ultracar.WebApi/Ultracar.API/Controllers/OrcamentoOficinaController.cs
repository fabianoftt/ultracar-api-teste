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
        public async Task<IActionResult> GetVeiculo(string placa)
        {
            var veiculo = _getVeiculoService.ObterVeiculo(placa);
            return Ok(veiculo);
        }

        [HttpGet("diagnosticos")]
        public async Task<IActionResult> GetDiagnostico([FromQuery] string busca)
        {
            var lista = _getDisgnosticoService.ObterDiagnostico(busca);
            return Ok(lista);
        }

        [HttpPost("sugestoes")]
        public async Task<IActionResult> Sugestoes([FromBody] SugestaoRequest request)
        {
            var sucesso = _postSugestoesService.SalvarSugestao(request);
            return Ok(sucesso);
        }

        [HttpPost("/api/v1/ordens-servico/{osId}/orcamento")]
        public async Task<IActionResult> PostOrcamento(int osId)
        {
            var sucesso = _postOrcamentoService.SalvarOrcamento(osId);
            return Created("", "");
        }

        [HttpGet("/api/v1/orcamentos/{id}")]
        public async Task<IActionResult> GetOrcamento(int id)
        {
            var retorno = _getOrcamentoOficinaService.ObterOrcamento(id);
            return Ok(retorno);
        }

        [HttpPut("/api/v1/orcamentos/{id}/itens")]
        public async Task<IActionResult> PutItens(int id, [FromBody] List<ItemRequest> itens)
        {
            var sucesso = _putItensOficinaService.AlterarItensOficina(id, itens);
            return Ok(new { id, itens });
        }

        [HttpPost("/api/v1/orcamentos/{id}/envio")]
        public async Task<IActionResult> PostEnvio(int id)
        {
            var sucesso = _postEnvioOficinaService.EnviarOficina(id);
            return Ok(sucesso);
        }

        [HttpPost("/api/v1/orcamentos/{id}/revisao")]
        public async Task<IActionResult> PostRevisao(int id)
        {
            var sucesso = _postRevisaoOficinaService.RevisarOrcamento(id);
            return Ok(sucesso);
        }

        [HttpGet("/api/v1/orcamentos/{id}/historico")]
        public async Task<IActionResult> GetHistorico(int id)
        {
            var listaHistorico = _getHistoricoOficinaService.ObterHistorico(id);
            return Ok(listaHistorico);
        }
    }
}

