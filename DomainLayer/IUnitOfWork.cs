using System.Threading;
using System.Threading.Tasks;

namespace DomainLayer
{
    public interface IUnitOfWork
    {
        void Commit();
        Task<int> CommitAsync(CancellationToken cancellationToken);
    }
}
