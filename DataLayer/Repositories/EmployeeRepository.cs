using DataLayer.Infrastructures;
using DomainLayer.Abstractions.Repositories;
using DomainLayer.Entities;

namespace DataLayer.Repositories
{
    class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
