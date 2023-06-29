using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelSystem_EF.Api.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Description 1", "Amenity 1" },
                    { 2, "Description 2", "Amenity 2" },
                    { 3, "Description 3", "Amenity 3" },
                    { 4, "Description 4", "Amenity 4" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Price", "ServiceName" },
                values: new object[,]
                {
                    { 1, "Description 1", 10.99, "Service 1" },
                    { 2, "Description 2", 15.99, "Service 2" },
                    { 3, "Description 3", 20.989999999999998, "Service 3" },
                    { 4, "Description 4", 25.989999999999998, "Service 4" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "RoomId", "Username" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", "Doe", "password1", 1, "johndoe" },
                    { 2, "jane.smith@example.com", "Jane", "Smith", "password2", 2, "janesmith" },
                    { 3, "mike.johnson@example.com", "Mike", "Johnson", "password3", 3, "mikejohnson" },
                    { 4, "sarah.williams@example.com", "Sarah", "Williams", "password4", 4, "sarahwilliams" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 1, "Great experience!", 4.5, new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4753), 1 },
                    { 2, "Average service", 3.7999999999999998, new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4766), 2 },
                    { 3, "Highly recommended!", 5.0, new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4770), 3 },
                    { 4, "Disappointing stay", 2.5, new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4773), 4 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Price", "RoomNumber", "RoomType", "UserId" },
                values: new object[,]
                {
                    { 1, 100.0, 101, "Standard", 1 },
                    { 2, 150.0, 102, "Deluxe", 2 },
                    { 3, 100.0, 201, "Standard", 3 },
                    { 4, 150.0, 202, "Deluxe", 4 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoomAmenities",
                columns: new[] { "Id", "AmenityId", "RoomId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 }
                });

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

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "BookingId", "PaymentDate" },
                values: new object[,]
                {
                    { 1, 100.0, 1, new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4060) },
                    { 2, 150.0, 2, new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4103) },
                    { 3, 200.0, 3, new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4106) },
                    { 4, 120.0, 4, new DateTime(2023, 6, 7, 18, 59, 47, 683, DateTimeKind.Local).AddTicks(4109) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookingServices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
