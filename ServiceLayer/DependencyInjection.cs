using InfrastructureLayer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Abstractions.Services;
using ServiceLayer.Services;

namespace ServiceLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddInfrastructure(configuration);
            services.AddScoped<ISADPService, SADPService>();

            return services;
        }
    }
}
