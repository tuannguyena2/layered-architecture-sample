using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    public class SubjectEntityConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Topic)
                   .WithMany(t => t.Subjects)
                   .HasForeignKey(x => x.TopicId);
        }
    }
}