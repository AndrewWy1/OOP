using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelSystem_EF.Api.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingServices",
                table: "BookingServices");

            migrationBuilder.DropIndex(
                name: "IX_BookingServices_BookingId",
                table: "BookingServices");

            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookingServices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingServices",
                table: "BookingServices",
                columns: new[] { "BookingId", "ServiveId" });

            migrationBuilder.InsertData(
                table: "BookingServices",
                columns: new[] { "BookingId", "ServiveId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 1 },
                    { 3, 3, 3 },
                    { 4, 4, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 6, 20, 20, 50, 59, 667, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 6, 20, 20, 50, 59, 667, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2023, 6, 20, 20, 50, 59, 667, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2023, 6, 20, 20, 50, 59, 667, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2023, 6, 20, 20, 50, 59, 667, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2023, 6, 20, 20, 50, 59, 667, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2023, 6, 20, 20, 50, 59, 667, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2023, 6, 20, 20, 50, 59, 667, DateTimeKind.Local).AddTicks(7944));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingServices",
                table: "BookingServices");

            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumns: new[] { "BookingId", "ServiveId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumns: new[] { "BookingId", "ServiveId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumns: new[] { "BookingId", "ServiveId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumns: new[] { "BookingId", "ServiveId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookingServices",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingServices",
                table: "BookingServices",
                column: "Id");

            migrationBuilder.InsertData(
                table: "BookingServices",
                columns: new[] { "Id", "BookingId", "Quantity", "ServiveId" },
                values: new object[,]
                {
                    { 1, 1, 2, 1 },
                    { 2, 2, 1, 2 },
                    { 3, 3, 3, 3 },
                    { 4, 4, 2, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.CreateIndex(
                name: "IX_BookingServices_BookingId",
                table: "BookingServices",
                column: "BookingId");
        }
    }
}
