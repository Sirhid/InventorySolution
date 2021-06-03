using Microsoft.EntityFrameworkCore.Migrations;

namespace HRIS.Infrastructure.Persistence.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypeVariation_ProductTypeVariationId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ProductTypeVariationId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypeVariation_ProductTypeVariationId",
                table: "Products",
                column: "ProductTypeVariationId",
                principalTable: "ProductTypeVariation",
                principalColumn: "ProductTypeVariationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypeVariation_ProductTypeVariationId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ProductTypeVariationId",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypeVariation_ProductTypeVariationId",
                table: "Products",
                column: "ProductTypeVariationId",
                principalTable: "ProductTypeVariation",
                principalColumn: "ProductTypeVariationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
