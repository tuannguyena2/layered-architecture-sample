using DataLayer.Infrastructures;
using DomainLayer.Abstractions.Repositories;
using DomainLayer.Entities;

namespace DataLayer.Repositories
{
    class TopicRepository : BaseRepository<Topic>, ITopicRepository
    {
        public TopicRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
