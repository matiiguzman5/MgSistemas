using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MgSistemas.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movimientos_Productos_ProductoIdProducto",
                table: "movimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_movimientos",
                table: "movimientos");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "movimientos",
                newName: "Movimientos");

            migrationBuilder.RenameColumn(
                name: "IdUsuarios",
                table: "Usuarios",
                newName: "IdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_movimientos_ProductoIdProducto",
                table: "Movimientos",
                newName: "IX_Movimientos_ProductoIdProducto");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movimientos",
                table: "Movimientos",
                column: "IdMovimiento");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Productos_ProductoIdProducto",
                table: "Movimientos",
                column: "ProductoIdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Productos_ProductoIdProducto",
                table: "Movimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movimientos",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "usuarios");

            migrationBuilder.RenameTable(
                name: "Movimientos",
                newName: "movimientos");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "usuarios",
                newName: "IdUsuarios");

            migrationBuilder.RenameIndex(
                name: "IX_Movimientos_ProductoIdProducto",
                table: "movimientos",
                newName: "IX_movimientos_ProductoIdProducto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "IdUsuarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_movimientos",
                table: "movimientos",
                column: "IdMovimiento");

            migrationBuilder.AddForeignKey(
                name: "FK_movimientos_Productos_ProductoIdProducto",
                table: "movimientos",
                column: "ProductoIdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
