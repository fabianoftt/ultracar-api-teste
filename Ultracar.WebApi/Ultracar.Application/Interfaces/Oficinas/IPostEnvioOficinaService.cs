namespace Ultracar.Application.Interfaces.Oficinas
{
    public interface IPostEnvioOficinaService
    {
        Task<string> EnviarOficina(int id);
    }
}
