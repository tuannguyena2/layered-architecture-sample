using DataLayer.Abstractions;
using System.Threading;
using System.Threading.Tasks;

namespace DataLayer.Infrastructures
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private readonly SADPContext _dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
            _dbContext = _dbFactory.Get();
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
