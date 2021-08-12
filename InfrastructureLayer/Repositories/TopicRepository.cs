using DomainLayer.Abstractions.Repositories;
using DomainLayer.Entities;
using InfrastructureLayer.Infrastructures;

namespace InfrastructureLayer.Repositories
{
    class TopicRepository : BaseRepository<Topic>, ITopicRepository
    {
        public TopicRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
