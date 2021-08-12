using DataLayer.Infrastructures;
using DomainLayer.Abstractions.Repositories;
using DomainLayer.Entities;

namespace DataLayer.Repositories
{
    class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
