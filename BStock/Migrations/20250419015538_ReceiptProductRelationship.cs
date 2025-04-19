using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BStock.Migrations
{
    /// <inheritdoc />
    public partial class ReceiptProductRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReceiptProduct_Products_ProductsProductId",
                table: "ProductReceiptProduct");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ReceiptProducts");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductsProductId",
                table: "ProductReceiptProduct",
                newName: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReceiptProduct_Products_ProductsId",
                table: "ProductReceiptProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReceiptProduct_Products_ProductsId",
                table: "ProductReceiptProduct");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "ProductReceiptProduct",
                newName: "ProductsProductId");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ReceiptProducts",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReceiptProduct_Products_ProductsProductId",
                table: "ProductReceiptProduct",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
