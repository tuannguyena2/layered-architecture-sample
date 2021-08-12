using DataLayer.Abstractions;
using DataLayer.Abstractions.Repositories;
using DataLayer.Entities;

namespace DataLayer.Repositories
{
    class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
