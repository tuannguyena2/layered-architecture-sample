﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkingProject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asssigments",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asssigments", x => new { x.EmployeeId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Asssigments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asssigments_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedDate", "Department", "Email", "IsDeleted", "LastModifiedDate", "Name", "WorkingProject" },
                values: new object[,]
                {
                    { 1677, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(8552), "GSS", "tuanan@kms-technology.com", false, null, "Tuan Nguyen", "LeaseQuery" },
                    { 656, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(8560), "HCDC", "nguyenho@kms-technology.com", false, null, "Nguyen Ho", "Elsevier" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 12, 11, 29, 10, 860, DateTimeKind.Local).AddTicks(2818), false, null, "Software Architecture Foundations" },
                    { 2, new DateTime(2021, 8, 12, 11, 29, 10, 861, DateTimeKind.Local).AddTicks(430), false, null, "Software Architecture Characteristic" },
                    { 3, new DateTime(2021, 8, 12, 11, 29, 10, 861, DateTimeKind.Local).AddTicks(451), false, null, "Software Architecture Styles" },
                    { 4, new DateTime(2021, 8, 12, 11, 29, 10, 861, DateTimeKind.Local).AddTicks(453), false, null, "Software Architecture Techniques and Softskills" },
                    { 5, new DateTime(2021, 8, 12, 11, 29, 10, 861, DateTimeKind.Local).AddTicks(454), false, null, "Software Architecture Proposals" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "LastModifiedDate", "Name", "TopicId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5618), false, null, "Introduction", 1 },
                    { 24, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5659), false, null, "Project B", 5 },
                    { 23, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5657), false, null, "Project A", 5 },
                    { 22, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5656), false, null, "Negotiation and Leadership Skills", 4 },
                    { 21, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5655), false, null, "Development Teams Effectiveness", 4 },
                    { 20, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5653), false, null, "Architecture Diagrams and Presentations", 4 },
                    { 19, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5652), false, null, "Architecture Risk Analyzing", 4 },
                    { 18, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5650), false, null, "Architecture Decisions", 4 },
                    { 17, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5649), false, null, "Microservices Architecture", 3 },
                    { 16, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5648), false, null, "Orchestration-Driven Service-Oriented Architecture", 3 },
                    { 15, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5646), false, null, "Space-Based Architecture", 3 },
                    { 14, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5645), false, null, "Event-Driven Architecture", 3 },
                    { 13, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5644), false, null, "Service-Based Architecture", 3 },
                    { 12, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5642), false, null, "Microkernel Architecture", 3 },
                    { 11, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5641), false, null, "Pipeline Architecture", 3 },
                    { 10, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5640), false, null, "Layered Architecture", 3 },
                    { 9, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5638), false, null, "Fundamental Architectural Patterns", 3 },
                    { 8, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5637), false, null, "Scope of Architecture Characteristics", 2 },
                    { 7, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5635), false, null, "Measuring Architecture Characteristics", 2 },
                    { 6, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5634), false, null, "Identifying Architecture Characteristics", 2 },
                    { 5, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5632), false, null, "Architecture Characteristics Definition", 2 },
                    { 4, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5631), false, null, "Component-Based Thinking", 1 },
                    { 3, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5629), false, null, "Modularity", 1 },
                    { 2, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5628), false, null, "Architecture Thinking", 1 },
                    { 25, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5660), false, null, "Project C", 5 },
                    { 26, new DateTime(2021, 8, 12, 11, 29, 10, 862, DateTimeKind.Local).AddTicks(5661), false, null, "Project D", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asssigments_SubjectId",
                table: "Asssigments",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TopicId",
                table: "Subjects",
                column: "TopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asssigments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
