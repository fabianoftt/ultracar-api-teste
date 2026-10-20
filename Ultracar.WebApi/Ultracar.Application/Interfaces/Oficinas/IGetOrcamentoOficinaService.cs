namespace Ultracar.Application.Interfaces.Oficinas
{
    public interface IGetOrcamentoOficinaService
    {
        Task<string> ObterOrcamento(int id);
    }
}
