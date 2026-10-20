namespace Ultracar.Application.Interfaces.Cliente
{
    public interface IGetOrcamentoClienteService
    {
        Task<string> ObterOrcamentoClienteService(string tokend);
    }
}
