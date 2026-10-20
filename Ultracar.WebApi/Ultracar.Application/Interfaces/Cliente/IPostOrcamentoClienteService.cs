using Ultracar.Application.Dtos.Request;

namespace Ultracar.Application.Interfaces.Cliente
{
    public interface IPostOrcamentoClienteService
    {
        Task<bool> SalvarDecisaoOrcamentoClienteService(DecisaoRequest request);
    }
}
