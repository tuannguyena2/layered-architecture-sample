using InfrastructureLayer.Utils;
using Microsoft.EntityFrameworkCore.Design;

namespace InfrastructureLayer.Infrastructures
{
    class DbContextFactory : IDesignTimeDbContextFactory<SADPContext>
    {
        private SADPContext _dataContext;

        public SADPContext CreateDbContext(string[] args)
        {
            var resolver = new DependencyResolver();
            _dataContext = resolver.ServiceProvider.GetService(typeof(SADPContext)) as SADPContext;

            return _dataContext;
        }
    }
}
