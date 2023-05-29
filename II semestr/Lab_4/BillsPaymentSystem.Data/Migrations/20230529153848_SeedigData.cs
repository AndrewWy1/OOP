using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillsPaymentSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedigData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LimitLeft",
                table: "CreditCards");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "LimitLeft",
                table: "CreditCards",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
