using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    public class AssignmentEntityConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasKey(e => new { e.EmployeeId, e.SubjectId });
            builder.HasOne(e => e.Employee).WithMany(m => m.Asssigments).HasForeignKey(f => f.EmployeeId);
            builder.HasOne(e => e.Subject).WithMany(m => m.Asssigments).HasForeignKey(f => f.SubjectId);
        }
    }
}