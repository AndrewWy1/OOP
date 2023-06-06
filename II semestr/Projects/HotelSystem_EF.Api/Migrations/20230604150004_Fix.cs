using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelSystem_EF.Api.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaumentId",
                table: "Payments",
                newName: "PaymentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Payments",
                newName: "PaumentId");
        }
    }
}
