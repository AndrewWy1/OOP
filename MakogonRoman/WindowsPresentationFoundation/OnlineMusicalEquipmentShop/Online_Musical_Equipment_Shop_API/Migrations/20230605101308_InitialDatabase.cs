using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Musical_Equipment_Shop_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryTitle" },
                values: new object[,]
                {
                    { new Guid("0bbed2e8-d0c7-4f8c-8af8-2a621c6ccf4b"), "Percussion" },
                    { new Guid("21b15c35-ddf6-41a4-a632-700aee480598"), "Drums" },
                    { new Guid("3d1c2c48-5fe5-48ed-8cd2-2b723a4270f3"), "Guitars" },
                    { new Guid("4608485b-e6b1-4d01-a611-680f1411779e"), "Amplifiers" },
                    { new Guid("658a0961-3114-48e0-9422-17b79861d2b7"), "Keyboards" },
                    { new Guid("8226cf9f-5e88-4136-a183-aef595b8a8a4"), "Accessories" },
                    { new Guid("85284a17-8f07-487e-9e6d-1016426a8709"), "DJEquipment" },
                    { new Guid("a6eddd97-242c-4cc8-ae78-7936efd0c38f"), "Winds" },
                    { new Guid("e6c6ae21-9dec-4221-b4b9-170797ba007b"), "RecordingEquipment" },
                    { new Guid("f5e50e3b-f1bf-4c1d-a520-489e31f981e0"), "Strings" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
