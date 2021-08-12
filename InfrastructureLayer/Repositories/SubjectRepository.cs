using DomainLayer.Abstractions.Repositories;
using DomainLayer.Entities;
using InfrastructureLayer.Infrastructures;

namespace InfrastructureLayer.Repositories
{
    class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
