using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Description", "EndDate", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1, "Description 1", new DateTime(2023, 6, 5, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9742), "Course 1", 9.9900000000000002, new DateTime(2023, 5, 29, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9703) },
                    { 2, "Description 2", new DateTime(2023, 6, 12, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9748), "Course 2", 19.989999999999998, new DateTime(2023, 5, 29, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9746) },
                    { 3, null, new DateTime(2023, 6, 19, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9753), "Course 3", 29.989999999999998, new DateTime(2023, 5, 29, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9751) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Birthday", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", "1234567890", true },
                    { 2, new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", null, false },
                    { 3, new DateTime(1998, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Johnson", "9876543210", true }
                });

            migrationBuilder.InsertData(
                table: "HomeworkSubmissions",
                columns: new[] { "HomeworkId", "Content", "ContentType", "CourseId", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { 1, "Homework content 1", 0, 1, 1, new DateTime(2023, 5, 29, 14, 35, 24, 695, DateTimeKind.Local).AddTicks(8597) },
                    { 2, "Homework content 2", 1, 1, 2, new DateTime(2023, 5, 29, 14, 35, 24, 695, DateTimeKind.Local).AddTicks(8612) },
                    { 3, "Homework content 3", 2, 2, 3, new DateTime(2023, 5, 29, 14, 35, 24, 695, DateTimeKind.Local).AddTicks(8614) }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "CourseId", "Name", "ResourceType", "Url" },
                values: new object[,]
                {
                    { 1, 1, "Resource 1", 0, "http://example.com/resource1" },
                    { 2, 2, "Resource 2", 1, "http://example.com/resource2" },
                    { 3, 2, "Resource 3", 2, "http://example.com/resource3" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HomeworkSubmissions",
                keyColumn: "HomeworkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HomeworkSubmissions",
                keyColumn: "HomeworkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HomeworkSubmissions",
                keyColumn: "HomeworkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);
        }
    }
}
