using System.Threading;
using System.Threading.Tasks;

namespace DataLayer.Abstractions
{
    public interface IUnitOfWork
    {
        void Commit();
        Task<int> CommitAsync(CancellationToken cancellationToken);
    }
}
