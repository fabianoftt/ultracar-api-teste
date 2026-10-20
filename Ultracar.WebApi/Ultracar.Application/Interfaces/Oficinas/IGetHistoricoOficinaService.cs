namespace Ultracar.Application.Interfaces.Oficinas
{
    public interface IGetHistoricoOficinaService
    {
        Task<string> ObterHistorico(int id);
    }
}
