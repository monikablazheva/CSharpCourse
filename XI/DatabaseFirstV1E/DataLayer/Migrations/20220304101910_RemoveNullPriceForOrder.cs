using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class RemoveNullPriceForOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersProductsQuantities_Orders_OrderID",
                table: "OrdersProductsQuantities");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersProductsQuantities_Products_ProductBarcode",
                table: "OrdersProductsQuantities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersProductsQuantities",
                table: "OrdersProductsQuantities");

            migrationBuilder.RenameTable(
                name: "OrdersProductsQuantities",
                newName: "OPQs");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersProductsQuantities_ProductBarcode",
                table: "OPQs",
                newName: "IX_OPQs_ProductBarcode");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OPQs",
                table: "OPQs",
                columns: new[] { "OrderID", "ProductBarcode" });

            migrationBuilder.AddForeignKey(
                name: "FK_OPQs_Orders_OrderID",
                table: "OPQs",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OPQs_Products_ProductBarcode",
                table: "OPQs",
                column: "ProductBarcode",
                principalTable: "Products",
                principalColumn: "Barcode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OPQs_Orders_OrderID",
                table: "OPQs");

            migrationBuilder.DropForeignKey(
                name: "FK_OPQs_Products_ProductBarcode",
                table: "OPQs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OPQs",
                table: "OPQs");

            migrationBuilder.RenameTable(
                name: "OPQs",
                newName: "OrdersProductsQuantities");

            migrationBuilder.RenameIndex(
                name: "IX_OPQs_ProductBarcode",
                table: "OrdersProductsQuantities",
                newName: "IX_OrdersProductsQuantities_ProductBarcode");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersProductsQuantities",
                table: "OrdersProductsQuantities",
                columns: new[] { "OrderID", "ProductBarcode" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProductsQuantities_Orders_OrderID",
                table: "OrdersProductsQuantities",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProductsQuantities_Products_ProductBarcode",
                table: "OrdersProductsQuantities",
                column: "ProductBarcode",
                principalTable: "Products",
                principalColumn: "Barcode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
