using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Musical_Equipment_Shop_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialAllDatabaseAndSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bbed2e8-d0c7-4f8c-8af8-2a621c6ccf4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21b15c35-ddf6-41a4-a632-700aee480598"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d1c2c48-5fe5-48ed-8cd2-2b723a4270f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4608485b-e6b1-4d01-a611-680f1411779e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("658a0961-3114-48e0-9422-17b79861d2b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8226cf9f-5e88-4136-a183-aef595b8a8a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85284a17-8f07-487e-9e6d-1016426a8709"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6eddd97-242c-4cc8-ae78-7936efd0c38f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6c6ae21-9dec-4221-b4b9-170797ba007b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5e50e3b-f1bf-4c1d-a520-489e31f981e0"));

            migrationBuilder.AlterColumn<string>(
                name: "CategoryTitle",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountriesTitle = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manufacturers_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstrumentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instruments_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instruments_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstrumentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Instruments_InstrumentsId",
                        column: x => x.InstrumentsId,
                        principalTable: "Instruments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountriesTitle" },
                values: new object[,]
                {
                    { new Guid("275bc5ba-d018-42b9-94d9-51223885133f"), "South Georgia and the South Sandwich Islands" },
                    { new Guid("30c1fdcd-119b-48ff-bff0-8431a487bd4c"), "Argentina" },
                    { new Guid("3648f415-b813-4858-aa44-d0ae0526ee86"), "Israel" },
                    { new Guid("39c90a69-0453-4512-962c-eeb511678557"), "Denmark" },
                    { new Guid("697dae8f-d1f3-45c2-8e6c-df50d3a905ad"), "Western Sahara" },
                    { new Guid("7dba1741-6469-4d9c-b40a-333941f9e253"), "Jamaica" },
                    { new Guid("9fb06550-24a3-4190-839d-698343fdcd82"), "Isle of Man" },
                    { new Guid("a12b7259-70b5-416b-a05d-e7ebddd9a334"), "Suriname" },
                    { new Guid("aa1df7e3-fa8f-4a1d-9e0b-4e623e72a40e"), "Nauru" },
                    { new Guid("b6b17bcd-f250-4b6b-bf1b-91e6f12cb166"), "Eritrea" },
                    { new Guid("bafbb5f1-7532-4298-b605-2e9937fdd234"), "Namibia" },
                    { new Guid("c21b3a08-629f-4e43-aa24-3b7b010a9521"), "Brazil" },
                    { new Guid("cb95fb58-d5cb-420b-bb8f-e3b02182084d"), "Gibraltar" },
                    { new Guid("ea57e523-1b57-470d-98c7-cf42709d49e8"), "Cuba" },
                    { new Guid("fefbc21f-1363-4d5c-8a9c-a07a80e2b553"), "Netherlands" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryTitle",
                table: "Categories",
                column: "CategoryTitle",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CountriesTitle",
                table: "Countries",
                column: "CountriesTitle",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_CategoriesId",
                table: "Instruments",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_ManufacturerId",
                table: "Instruments",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CountriesId",
                table: "Items",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_InstrumentsId",
                table: "Items",
                column: "InstrumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_CountriesId",
                table: "Manufacturers",
                column: "CountriesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryTitle",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryTitle",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
