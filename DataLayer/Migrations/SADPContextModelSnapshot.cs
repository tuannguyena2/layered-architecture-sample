﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(SADPContext))]
    partial class SADPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Entities.Assignment", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRegistered")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Asssigments");
                });

            modelBuilder.Entity("DataLayer.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingProject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1677,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(9918),
                            Department = "GSS",
                            Email = "tuanan@kms-technology.com",
                            IsDeleted = false,
                            Name = "Tuan Nguyen",
                            WorkingProject = "LeaseQuery"
                        },
                        new
                        {
                            Id = 656,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(9925),
                            Department = "HCDC",
                            Email = "nguyenho@kms-technology.com",
                            IsDeleted = false,
                            Name = "Nguyen Ho",
                            WorkingProject = "Elsevier"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(6998),
                            IsDeleted = false,
                            Name = "Introduction",
                            TopicId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7006),
                            IsDeleted = false,
                            Name = "Architecture Thinking",
                            TopicId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7008),
                            IsDeleted = false,
                            Name = "Modularity",
                            TopicId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7009),
                            IsDeleted = false,
                            Name = "Component-Based Thinking",
                            TopicId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7011),
                            IsDeleted = false,
                            Name = "Architecture Characteristics Definition",
                            TopicId = 2
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7012),
                            IsDeleted = false,
                            Name = "Identifying Architecture Characteristics",
                            TopicId = 2
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7013),
                            IsDeleted = false,
                            Name = "Measuring Architecture Characteristics",
                            TopicId = 2
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7015),
                            IsDeleted = false,
                            Name = "Scope of Architecture Characteristics",
                            TopicId = 2
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7016),
                            IsDeleted = false,
                            Name = "Fundamental Architectural Patterns",
                            TopicId = 3
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7017),
                            IsDeleted = false,
                            Name = "Layered Architecture",
                            TopicId = 3
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7019),
                            IsDeleted = false,
                            Name = "Pipeline Architecture",
                            TopicId = 3
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7020),
                            IsDeleted = false,
                            Name = "Microkernel Architecture",
                            TopicId = 3
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7022),
                            IsDeleted = false,
                            Name = "Service-Based Architecture",
                            TopicId = 3
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7023),
                            IsDeleted = false,
                            Name = "Event-Driven Architecture",
                            TopicId = 3
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7024),
                            IsDeleted = false,
                            Name = "Space-Based Architecture",
                            TopicId = 3
                        },
                        new
                        {
                            Id = 16,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7026),
                            IsDeleted = false,
                            Name = "Orchestration-Driven Service-Oriented Architecture",
                            TopicId = 3
                        },
                        new
                        {
                            Id = 17,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7027),
                            IsDeleted = false,
                            Name = "Microservices Architecture",
                            TopicId = 3
                        },
                        new
                        {
                            Id = 18,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7029),
                            IsDeleted = false,
                            Name = "Architecture Decisions",
                            TopicId = 4
                        },
                        new
                        {
                            Id = 19,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7030),
                            IsDeleted = false,
                            Name = "Architecture Risk Analyzing",
                            TopicId = 4
                        },
                        new
                        {
                            Id = 20,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7032),
                            IsDeleted = false,
                            Name = "Architecture Diagrams and Presentations",
                            TopicId = 4
                        },
                        new
                        {
                            Id = 21,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7033),
                            IsDeleted = false,
                            Name = "Development Teams Effectiveness",
                            TopicId = 4
                        },
                        new
                        {
                            Id = 22,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7034),
                            IsDeleted = false,
                            Name = "Negotiation and Leadership Skills",
                            TopicId = 4
                        },
                        new
                        {
                            Id = 23,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7036),
                            IsDeleted = false,
                            Name = "Project A",
                            TopicId = 5
                        },
                        new
                        {
                            Id = 24,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7037),
                            IsDeleted = false,
                            Name = "Project B",
                            TopicId = 5
                        },
                        new
                        {
                            Id = 25,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7039),
                            IsDeleted = false,
                            Name = "Project C",
                            TopicId = 5
                        },
                        new
                        {
                            Id = 26,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 617, DateTimeKind.Local).AddTicks(7040),
                            IsDeleted = false,
                            Name = "Project D",
                            TopicId = 5
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 615, DateTimeKind.Local).AddTicks(4829),
                            IsDeleted = false,
                            Name = "Software Architecture Foundations"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 616, DateTimeKind.Local).AddTicks(2050),
                            IsDeleted = false,
                            Name = "Software Architecture Characteristic"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 616, DateTimeKind.Local).AddTicks(2062),
                            IsDeleted = false,
                            Name = "Software Architecture Styles"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 616, DateTimeKind.Local).AddTicks(2064),
                            IsDeleted = false,
                            Name = "Software Architecture Techniques and Softskills"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2021, 8, 13, 13, 52, 33, 616, DateTimeKind.Local).AddTicks(2065),
                            IsDeleted = false,
                            Name = "Software Architecture Proposals"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Assignment", b =>
                {
                    b.HasOne("DataLayer.Entities.Employee", "Employee")
                        .WithMany("Asssigments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.Subject", "Subject")
                        .WithMany("Asssigments")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("DataLayer.Entities.Subject", b =>
                {
                    b.HasOne("DataLayer.Entities.Topic", "Topic")
                        .WithMany("Subjects")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("DataLayer.Entities.Employee", b =>
                {
                    b.Navigation("Asssigments");
                });

            modelBuilder.Entity("DataLayer.Entities.Subject", b =>
                {
                    b.Navigation("Asssigments");
                });

            modelBuilder.Entity("DataLayer.Entities.Topic", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
