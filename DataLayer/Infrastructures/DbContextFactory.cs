using DataLayer.Utils;
using Microsoft.EntityFrameworkCore.Design;

namespace DataLayer.Infrastructures
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
