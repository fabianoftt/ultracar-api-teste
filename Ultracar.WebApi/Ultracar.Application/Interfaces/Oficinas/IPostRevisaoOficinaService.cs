namespace Ultracar.Application.Interfaces.Oficinas
{
    public interface IPostRevisaoOficinaService
    {
        Task<string> RevisarOrcamento(int id);
    }
}
