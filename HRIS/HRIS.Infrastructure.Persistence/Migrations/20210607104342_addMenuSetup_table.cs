using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRIS.Infrastructure.Persistence.Migrations
{
    public partial class addMenuSetup_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuSetup",
                columns: table => new
                {
                    MenuIdentity = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<string>(nullable: true),
                    MenuName = table.Column<string>(nullable: true),
                    ParentMenuId = table.Column<string>(nullable: true),
                    UserRole = table.Column<string>(nullable: true),
                    MenuFileName = table.Column<string>(nullable: true),
                    MenuUrl = table.Column<string>(nullable: true),
                    ImgClass = table.Column<string>(nullable: true),
                    InstitutionCode = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    SectionName = table.Column<string>(nullable: true),
                    SectionImgClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuSetup", x => x.MenuIdentity);
                });

            migrationBuilder.CreateTable(
                name: "UsersRolePermission",
                columns: table => new
                {
                    UserPermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuIdentity = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedById = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRolePermission", x => x.UserPermissionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuSetup");

            migrationBuilder.DropTable(
                name: "UsersRolePermission");
        }
    }
}
