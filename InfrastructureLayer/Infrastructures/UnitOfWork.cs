using DomainLayer;
using System.Threading;
using System.Threading.Tasks;

namespace InfrastructureLayer.Infrastructures
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private SADPContext _dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        protected SADPContext DatabaseContext
        {
            get { return _dbContext ??= _dbFactory.Get(); }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task<int> CommitAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
