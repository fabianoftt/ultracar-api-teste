using Ultracar.Application.Dtos.Request;

namespace Ultracar.Application.Interfaces.Oficinas
{
    public interface IPutItensOficinaService
    {
        Task<string> AlterarItensOficina(int id, List<ItemRequest> itens);
    }
}
