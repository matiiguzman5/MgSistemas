using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MgSistemas.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyToProductoinMov : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Productos_ProductoIdProducto",
                table: "Movimientos");

            migrationBuilder.DropIndex(
                name: "IX_Movimientos_ProductoIdProducto",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "ProductoIdProducto",
                table: "Movimientos");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_IdProducto",
                table: "Movimientos",
                column: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Productos_IdProducto",
                table: "Movimientos",
                column: "IdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Productos_IdProducto",
                table: "Movimientos");

            migrationBuilder.DropIndex(
                name: "IX_Movimientos_IdProducto",
                table: "Movimientos");

            migrationBuilder.AddColumn<int>(
                name: "ProductoIdProducto",
                table: "Movimientos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_ProductoIdProducto",
                table: "Movimientos",
                column: "ProductoIdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Productos_ProductoIdProducto",
                table: "Movimientos",
                column: "ProductoIdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
