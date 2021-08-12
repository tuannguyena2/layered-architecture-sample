using DataLayer.Abstractions;
using DataLayer.Abstractions.Repositories;
using DataLayer.Entities;

namespace DataLayer.Repositories
{
    class AssignmentRepository : BaseRepository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
