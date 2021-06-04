using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRIS.Infrastructure.Persistence.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Voucher");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Voucher");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Voucher");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "VendorReturn");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "VendorReturn");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "VendorReturn");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "VAT");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "VAT");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "VAT");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "StorePurchase");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "StorePurchase");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "StorePurchase");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ProductTypeVariation");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "ProductTypeVariation");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "ProductTypeVariation");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Expenditure");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Expenditure");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Expenditure");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CustomerReturn");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "CustomerReturn");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "CustomerReturn");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Category");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Voucher",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Voucher",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Voucher",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "VendorReturn",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "VendorReturn",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "VendorReturn",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "VAT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "VAT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "VAT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Supplier",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "SubCategory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "SubCategory",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "SubCategory",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "StorePurchase",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "StorePurchase",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "StorePurchase",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductTypeVariation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "ProductTypeVariation",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductTypeVariation",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Expenditure",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Expenditure",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Expenditure",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Expenditure",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "CustomerReturn",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "CustomerReturn",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "CustomerReturn",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Category",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Category",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Voucher");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Voucher");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Voucher");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "VendorReturn");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "VendorReturn");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "VendorReturn");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "VAT");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "VAT");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "VAT");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "StorePurchase");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "StorePurchase");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "StorePurchase");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ProductTypeVariation");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "ProductTypeVariation");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "ProductTypeVariation");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Expenditure");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Expenditure");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Expenditure");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Expenditure");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "CustomerReturn");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "CustomerReturn");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "CustomerReturn");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Category");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Voucher",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Voucher",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Voucher",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "VendorReturn",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "VendorReturn",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "VendorReturn",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "VAT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "VAT",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "VAT",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Supplier",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Supplier",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "SubCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "SubCategory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "SubCategory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "StorePurchase",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "StorePurchase",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "StorePurchase",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ProductTypeVariation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "ProductTypeVariation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "ProductTypeVariation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Expenditure",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Expenditure",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Expenditure",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CustomerReturn",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "CustomerReturn",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "CustomerReturn",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Category",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Category",
                type: "datetime2",
                nullable: true);
        }
    }
}
