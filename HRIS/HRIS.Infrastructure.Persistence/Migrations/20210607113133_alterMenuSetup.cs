using Microsoft.EntityFrameworkCore.Migrations;

namespace HRIS.Infrastructure.Persistence.Migrations
{
    public partial class alterMenuSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "MenuSetup");

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "MenuSetup",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "MenuSetup");

            migrationBuilder.AddColumn<string>(
                name: "UserRole",
                table: "MenuSetup",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
