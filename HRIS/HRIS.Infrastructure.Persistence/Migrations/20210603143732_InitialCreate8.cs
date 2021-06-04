using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HRIS.Infrastructure.Persistence.Migrations
{
    public partial class InitialCreate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "CustomerVoucher",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));



            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "CustomerVoucher",
                nullable: true);





            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "CustomerVoucher",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "CustomerVoucher");



            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "CustomerVoucher");




            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "CustomerVoucher");
        }
    }
}
