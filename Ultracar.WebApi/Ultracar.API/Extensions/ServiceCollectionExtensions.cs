using Ultracar.Application.Interfaces.Cliente;
using Ultracar.Application.Interfaces.Oficinas;
using Ultracar.Application.Services.Clientes;
using Ultracar.Application.Services.Oficinas;

namespace Ultracar.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUltracarServices(this IServiceCollection services)
        {
            // Registra os serviços
            services.AddScoped<IGetDisgnosticoService, GetDisgnosticoService>();
            services.AddScoped<IGetHistoricoOficinaService, GetHistoricoOficinaService>();
            services.AddScoped<IGetOrcamentoOficinaService, GetOrcamentoOficinaService>();

            services.AddScoped<IGetVeiculoService, GetVeiculoService>();
            services.AddScoped<IPostEnvioOficinaService, PostEnvioOficinaService>();
            services.AddScoped<IPostOrcamentoService, PostOrcamentoService>();
            services.AddScoped<IPostRevisaoOficinaService, PostRevisaoOficinaService>();
            services.AddScoped<IPostSugestoesService, PostSugestoesService>();
            services.AddScoped<IPutItensOficinaService, PutItensOficinaService>();



            services.AddScoped<IGetOrcamentoClienteService, GetOrcamentoClienteService>();
            services.AddScoped<IPostOrcamentoClienteService, PostOrcamentoClienteService>();

            return services;
        }
    }
}
