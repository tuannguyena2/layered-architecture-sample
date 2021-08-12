using DataLayer.Utils;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;

namespace DataLayer.Infrastructures
{
    class DbContextFactory : IDesignTimeDbContextFactory<SADPContext>
    {
        private SADPContext _dataContext;

        public SADPContext CreateDbContext(string[] args)
        {
            var resolver = new DependencyResolver
            {
                CurrentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "../WebApp")
            };
            _dataContext = resolver.ServiceProvider.GetService(typeof(SADPContext)) as SADPContext;

            return _dataContext;
        }
    }
}
