using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
    internal static class DbContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedTopic();
            modelBuilder.SeedSubject();
            modelBuilder.SeedEmployee();
        }

        private static void SeedTopic(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasData(
                new Topic { Id = 1, Name = "Software Architecture Foundations", CreatedDate = DateTime.Now },
                new Topic { Id = 2, Name = "Software Architecture Characteristic", CreatedDate = DateTime.Now },
                new Topic { Id = 3, Name = "Software Architecture Styles", CreatedDate = DateTime.Now },
                new Topic { Id = 4, Name = "Software Architecture Techniques and Softskills", CreatedDate = DateTime.Now },
                new Topic { Id = 5, Name = "Software Architecture Proposals", CreatedDate = DateTime.Now });
        }

        private static void SeedSubject(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Introduction", TopicId = 1, CreatedDate = DateTime.Now },
                new Subject { Id = 2, Name = "Architecture Thinking", TopicId = 1, CreatedDate = DateTime.Now },
                new Subject { Id = 3, Name = "Modularity", TopicId = 1, CreatedDate = DateTime.Now },
                new Subject { Id = 4, Name = "Component-Based Thinking", TopicId = 1, CreatedDate = DateTime.Now },
                new Subject { Id = 5, Name = "Architecture Characteristics Definition", TopicId = 2, CreatedDate = DateTime.Now },
                new Subject { Id = 6, Name = "Identifying Architecture Characteristics", TopicId = 2, CreatedDate = DateTime.Now },
                new Subject { Id = 7, Name = "Measuring Architecture Characteristics", TopicId = 2, CreatedDate = DateTime.Now },
                new Subject { Id = 8, Name = "Scope of Architecture Characteristics", TopicId = 2, CreatedDate = DateTime.Now },
                new Subject { Id = 9, Name = "Fundamental Architectural Patterns", TopicId = 3, CreatedDate = DateTime.Now },
                new Subject { Id = 10, Name = "Layered Architecture", TopicId = 3, CreatedDate = DateTime.Now },
                new Subject { Id = 11, Name = "Pipeline Architecture", TopicId = 3, CreatedDate = DateTime.Now },
                new Subject { Id = 12, Name = "Microkernel Architecture", TopicId = 3, CreatedDate = DateTime.Now },
                new Subject { Id = 13, Name = "Service-Based Architecture", TopicId = 3, CreatedDate = DateTime.Now },
                new Subject { Id = 14, Name = "Event-Driven Architecture", TopicId = 3, CreatedDate = DateTime.Now },
                new Subject { Id = 15, Name = "Space-Based Architecture", TopicId = 3, CreatedDate = DateTime.Now },
                new Subject { Id = 16, Name = "Orchestration-Driven Service-Oriented Architecture", TopicId = 3, CreatedDate = DateTime.Now },
                new Subject { Id = 17, Name = "Microservices Architecture", TopicId = 3, CreatedDate = DateTime.Now },
                new Subject { Id = 18, Name = "Architecture Decisions", TopicId = 4, CreatedDate = DateTime.Now },
                new Subject { Id = 19, Name = "Architecture Risk Analyzing", TopicId = 4, CreatedDate = DateTime.Now },
                new Subject { Id = 20, Name = "Architecture Diagrams and Presentations", TopicId = 4, CreatedDate = DateTime.Now },
                new Subject { Id = 21, Name = "Development Teams Effectiveness", TopicId = 4, CreatedDate = DateTime.Now },
                new Subject { Id = 22, Name = "Negotiation and Leadership Skills", TopicId = 4, CreatedDate = DateTime.Now },
                new Subject { Id = 23, Name = "Project A", TopicId = 5, CreatedDate = DateTime.Now },
                new Subject { Id = 24, Name = "Project B", TopicId = 5, CreatedDate = DateTime.Now },
                new Subject { Id = 25, Name = "Project C", TopicId = 5, CreatedDate = DateTime.Now },
                new Subject { Id = 26, Name = "Project D", TopicId = 5, CreatedDate = DateTime.Now }
                );
        }

        private static void SeedEmployee(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1677, Name = "Tuan Nguyen", Email = "tuanan@kms-technology.com", Department = "GSS", WorkingProject = "LeaseQuery", CreatedDate = DateTime.Now },
                new Employee { Id = 656, Name = "Nguyen Ho", Email = "nguyenho@kms-technology.com", Department = "HCDC", WorkingProject = "Elsevier", CreatedDate = DateTime.Now }
                );
        }
    }
}
