using DomainLayer.Abstractions.Repositories;
using DomainLayer.Entities;
using InfrastructureLayer.Infrastructures;

namespace InfrastructureLayer.Repositories
{
    class AssignmentRepository : BaseRepository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
