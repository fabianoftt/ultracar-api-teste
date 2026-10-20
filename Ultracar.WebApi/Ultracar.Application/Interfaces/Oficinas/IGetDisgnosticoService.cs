namespace Ultracar.Application.Interfaces.Oficinas
{
    public interface IGetDisgnosticoService
    {
        Task<string> ObterDiagnostico(string busca);
    }
}
