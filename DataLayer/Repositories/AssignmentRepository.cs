using DataLayer.Infrastructures;
using DomainLayer.Abstractions.Repositories;
using DomainLayer.Entities;

namespace DataLayer.Repositories
{
    class AssignmentRepository : BaseRepository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
