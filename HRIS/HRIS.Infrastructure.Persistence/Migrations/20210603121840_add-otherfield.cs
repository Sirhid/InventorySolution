using Microsoft.EntityFrameworkCore.Migrations;

namespace HRIS.Infrastructure.Persistence.Migrations
{
    public partial class addotherfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "VAT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDisable",
                table: "VAT",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "VAT");

            migrationBuilder.DropColumn(
                name: "isDisable",
                table: "VAT");
        }
    }
}
