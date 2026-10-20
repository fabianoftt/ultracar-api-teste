using Ultracar.Application.Interfaces.Cliente;
using Ultracar.Application.Services.Clientes;
using Ultracar.Application.Services.Oficinas;

namespace Ultracar.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUltracarServices(this IServiceCollection services)
        {
            // Registra os serviços
            services.AddScoped<IOficinaService, OficinaService>();
            services.AddScoped<IGetOrcamentoClienteService, GetOrcamentoClienteService>();
            services.AddScoped<IPostOrcamentoClienteService, PostOrcamentoClienteService>();

            return services;
        }
    }
}
