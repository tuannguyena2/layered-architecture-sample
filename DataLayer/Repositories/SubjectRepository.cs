using DataLayer.Abstractions;
using DataLayer.Abstractions.Repositories;
using DataLayer.Entities;

namespace DataLayer.Repositories
{
    class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
