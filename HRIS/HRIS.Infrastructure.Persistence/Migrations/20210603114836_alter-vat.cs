using Microsoft.EntityFrameworkCore.Migrations;

namespace HRIS.Infrastructure.Persistence.Migrations
{
    public partial class altervat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "VAT");

            migrationBuilder.AddColumn<double>(
                name: "percentage",
                table: "VAT",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "percentage",
                table: "VAT");

            migrationBuilder.AddColumn<double>(
                name: "Value",
                table: "VAT",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
