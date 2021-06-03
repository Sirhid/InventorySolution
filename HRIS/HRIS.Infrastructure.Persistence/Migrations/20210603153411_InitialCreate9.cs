using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HRIS.Infrastructure.Persistence.Migrations
{
    public partial class InitialCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SalesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    SellingPrice = table.Column<double>(nullable: false),
                    VAT = table.Column<double>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    IsVoucherUsed = table.Column<bool>(nullable: false),
                    CustomerVoucherId = table.Column<int>(nullable: true),
                    IsPaid = table.Column<bool>(nullable: false),
                    RecieptNumber = table.Column<string>(nullable: true),
                    BillNumber = table.Column<string>(nullable: true),
                    DatePaid = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SalesId);
                });

            migrationBuilder.CreateTable(
                name: "StoreSetup",
                columns: table => new
                {
                    StoreSetupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    StoreName = table.Column<string>(nullable: true),
                    StoreAddress = table.Column<string>(nullable: true),
                    StorePhone = table.Column<string>(nullable: true),
                    StoreEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreSetup", x => x.StoreSetupId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "StoreSetup");


        }
    }
}
