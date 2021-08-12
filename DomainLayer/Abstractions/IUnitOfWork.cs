using System.Threading;
using System.Threading.Tasks;

namespace DomainLayer.Abstractions
{
    public interface IUnitOfWork
    {
        void Commit();
        Task<int> CommitAsync(CancellationToken cancellationToken);
    }
}
