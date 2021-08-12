using System;

namespace DataLayer.Infrastructures
{
    public interface IDbFactory : IDisposable
    {
        SADPContext Get();
    }

    class DbFactory : Disposable, IDbFactory
    {
        private readonly DbContextFactory _dbFactory;
        private SADPContext _dbContext;

        public DbFactory(DbContextFactory dbContextFactory)
        {
            _dbFactory = dbContextFactory;
        }

        protected override void DisposeCore()
        {
            if (_dbContext != null) _dbContext.Dispose();
        }

        public SADPContext Get()
        {
            return _dbContext ??= _dbFactory.CreateDbContext(null);
        }
    }
}
