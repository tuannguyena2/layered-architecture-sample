using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InfrastructureLayer
{
    public class SADPContext : DbContext
    {
        public SADPContext(DbContextOptions<SADPContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Seed();
            base.OnModelCreating(builder);
        }

        #region DbSet
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Assignment> Asssigments { get; set; }
        #endregion
    }
}
