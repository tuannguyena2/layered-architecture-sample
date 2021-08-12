using DataLayer.Abstractions;
using DataLayer.Abstractions.Repositories;
using DataLayer.Entities;

namespace DataLayer.Repositories
{
    class TopicRepository : BaseRepository<Topic>, ITopicRepository
    {
        public TopicRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
