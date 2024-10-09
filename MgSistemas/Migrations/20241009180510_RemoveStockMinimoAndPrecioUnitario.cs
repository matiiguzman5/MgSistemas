using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MgSistemas.Migrations
{
    /// <inheritdoc />
    public partial class RemoveStockMinimoAndPrecioUnitario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_productos_ProductoIdProducto",
                table: "Movimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movimientos",
                table: "Movimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productos",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "StockMinimo",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "fechaSalida",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "precioUnitario",
                table: "productos");

            migrationBuilder.RenameTable(
                name: "Movimientos",
                newName: "movimientos");

            migrationBuilder.RenameTable(
                name: "productos",
                newName: "producto");

            migrationBuilder.RenameIndex(
                name: "IX_Movimientos_ProductoIdProducto",
                table: "movimientos",
                newName: "IX_movimientos_ProductoIdProducto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_movimientos",
                table: "movimientos",
                column: "IdMovimiento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producto",
                table: "producto",
                column: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_movimientos_producto_ProductoIdProducto",
                table: "movimientos",
                column: "ProductoIdProducto",
                principalTable: "producto",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movimientos_producto_ProductoIdProducto",
                table: "movimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_movimientos",
                table: "movimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producto",
                table: "producto");

            migrationBuilder.RenameTable(
                name: "movimientos",
                newName: "Movimientos");

            migrationBuilder.RenameTable(
                name: "producto",
                newName: "productos");

            migrationBuilder.RenameIndex(
                name: "IX_movimientos_ProductoIdProducto",
                table: "Movimientos",
                newName: "IX_Movimientos_ProductoIdProducto");

            migrationBuilder.AddColumn<int>(
                name: "StockMinimo",
                table: "productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaSalida",
                table: "productos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "precioUnitario",
                table: "productos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movimientos",
                table: "Movimientos",
                column: "IdMovimiento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productos",
                table: "productos",
                column: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_productos_ProductoIdProducto",
                table: "Movimientos",
                column: "ProductoIdProducto",
                principalTable: "productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
