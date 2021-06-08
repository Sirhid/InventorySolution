using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRIS.Infrastructure.Persistence.Migrations
{
    public partial class addAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "UsersRolePermission",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "UsersRolePermission",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "UsersRolePermission",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "UsersRolePermission",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UsersRolePermission",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "UsersRolePermission",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MenuSetup",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "MenuSetup",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "MenuSetup",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "MenuSetup",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "MenuSetup",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MenuSetup",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "MenuSetup",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "UsersRolePermission");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "UsersRolePermission");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "UsersRolePermission");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "UsersRolePermission");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UsersRolePermission");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "UsersRolePermission");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MenuSetup");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "MenuSetup");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "MenuSetup");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "MenuSetup");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "MenuSetup");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MenuSetup");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "MenuSetup");
        }
    }
}
