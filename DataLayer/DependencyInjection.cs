using DataLayer.Infrastructures;
using DataLayer.Repositories;
using DomainLayer.Abstractions;
using DomainLayer.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SADPContext>(options => options.UseSqlServer(configuration.GetConnectionString(nameof(SADPContext))));
            services.AddScoped<DbContextFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDbFactory, DbFactory>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<ITopicRepository, TopicRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<IAssignmentRepository, AssignmentRepository>();

            return services;
        }
    }
}
