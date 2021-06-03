using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRIS.Infrastructure.Persistence.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CustomerVoucher",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CustomerVoucher",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "CustomerVoucher",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "CustomerVoucher",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "CustomerVoucher",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CustomerVoucher",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "CustomerVoucher",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CustomerVoucher");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CustomerVoucher");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "CustomerVoucher");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "CustomerVoucher");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "CustomerVoucher");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CustomerVoucher");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "CustomerVoucher");
        }
    }
}
