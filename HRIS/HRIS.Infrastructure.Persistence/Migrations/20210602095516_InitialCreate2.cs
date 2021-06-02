using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HRIS.Infrastructure.Persistence.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductVariation_ProductVariationId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductVariation");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductVariationId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductVariationId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeVariationId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Expenditure",
                columns: table => new
                {
                    ExpenditureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    ExpenditureDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenditure", x => x.ExpenditureId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypeVariation",
                columns: table => new
                {
                    ProductTypeVariationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeVariation", x => x.ProductTypeVariationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeVariationId",
                table: "Products",
                column: "ProductTypeVariationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypeVariation_ProductTypeVariationId",
                table: "Products",
                column: "ProductTypeVariationId",
                principalTable: "ProductTypeVariation",
                principalColumn: "ProductTypeVariationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypeVariation_ProductTypeVariationId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Expenditure");

            migrationBuilder.DropTable(
                name: "ProductTypeVariation");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductTypeVariationId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductTypeVariationId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductVariationId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductVariation",
                columns: table => new
                {
                    ProductVariationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariation", x => x.ProductVariationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductVariationId",
                table: "Products",
                column: "ProductVariationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductVariation_ProductVariationId",
                table: "Products",
                column: "ProductVariationId",
                principalTable: "ProductVariation",
                principalColumn: "ProductVariationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
