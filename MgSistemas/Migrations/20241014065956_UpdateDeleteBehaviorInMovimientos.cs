using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MgSistemas.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDeleteBehaviorInMovimientos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Productos_IdProducto",
                table: "Movimientos");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Productos_IdProducto",
                table: "Movimientos",
                column: "IdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Productos_IdProducto",
                table: "Movimientos");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Productos_IdProducto",
                table: "Movimientos",
                column: "IdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
