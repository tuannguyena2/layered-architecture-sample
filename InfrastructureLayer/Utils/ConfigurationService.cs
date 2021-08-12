using Microsoft.Extensions.Configuration;
using System.IO;

namespace InfrastructureLayer.Utils
{
    public interface IConfigurationService
    {
        IConfiguration GetConfiguration();
    }

    public class ConfigurationService : IConfigurationService
    {
        public string CurrentDirectory { get; set; }

        public ConfigurationService()
        { }

        public IConfiguration GetConfiguration()
        {
            CurrentDirectory ??= Directory.GetCurrentDirectory();
            return new ConfigurationBuilder()
                .SetBasePath(CurrentDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.Development.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }
    }
}
