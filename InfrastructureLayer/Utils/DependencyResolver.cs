using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace InfrastructureLayer.Utils
{
    public class DependencyResolver
    {
        public IServiceProvider ServiceProvider { get; }

        public DependencyResolver()
        {
            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IConfigurationService, ConfigurationService>();

            services.AddTransient(provider =>
            {
                var configService = provider.GetService<IConfigurationService>();
                var connectionString = configService.GetConfiguration().GetConnectionString(nameof(SADPContext));
                var optionsBuilder = new DbContextOptionsBuilder<SADPContext>();
                optionsBuilder.UseSqlServer(connectionString);
                return new SADPContext(optionsBuilder.Options);
            });
        }
    }
}
