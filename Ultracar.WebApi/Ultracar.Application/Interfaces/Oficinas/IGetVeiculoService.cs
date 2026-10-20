namespace Ultracar.Application.Interfaces.Oficinas
{
    public interface IGetVeiculoService
    {
        Task<string> ObterVeiculo(string placa);
    }
}
