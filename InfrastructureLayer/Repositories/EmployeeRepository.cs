using DomainLayer.Abstractions.Repositories;
using DomainLayer.Entities;
using InfrastructureLayer.Infrastructures;

namespace InfrastructureLayer.Repositories
{
    class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
