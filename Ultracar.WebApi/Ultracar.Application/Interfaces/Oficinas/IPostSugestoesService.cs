using Ultracar.Application.Dtos.Request;

namespace Ultracar.Application.Interfaces.Oficinas
{
    public interface IPostSugestoesService
    {
        Task<string> SalvarSugestao(SugestaoRequest request);
    }
}
