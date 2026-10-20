namespace Ultracar.Application.Interfaces.Oficinas
{
    public interface IPostOrcamentoService
    {
        Task<string?> SalvarOrcamento(int osId);
    }
}
