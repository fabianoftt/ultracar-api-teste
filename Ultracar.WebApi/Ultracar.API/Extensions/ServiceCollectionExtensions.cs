using Ultracar.Application.Clientes;
using Ultracar.Application.Oficinas;

namespace Ultracar.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUltracarServices(this IServiceCollection services)
        {
            // Registra os serviços
            services.AddScoped<IOficinaService, OficinaService>();
            services.AddScoped<IClienteService, ClienteService>();

            return services;
        }
    }
}
