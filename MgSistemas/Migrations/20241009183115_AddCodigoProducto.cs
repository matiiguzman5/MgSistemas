using Microsoft.EntityFrameworkCore.Migrations;



#nullable disable

namespace MgSistemas.Migrations
{
    /// <inheritdoc />
    public partial class AddCodigoProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movimientos_producto_ProductoIdProducto",
                table: "movimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producto",
                table: "producto");

            migrationBuilder.RenameTable(
                name: "producto",
                newName: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "CodigoProducto",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_movimientos_Productos_ProductoIdProducto",
                table: "movimientos",
                column: "ProductoIdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movimientos_Productos_ProductoIdProducto",
                table: "movimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "CodigoProducto",
                table: "Productos");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "producto");

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
    }
}
