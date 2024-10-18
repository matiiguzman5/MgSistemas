using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MgSistemas.Migrations
{
    /// <inheritdoc />
    public partial class AddRequerimiento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requerimientos",
                columns: table => new
                {
                    IdRequerimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NroRequerimiento = table.Column<int>(type: "int", nullable: false),
                    Responsable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prioridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requerimientos", x => x.IdRequerimiento);
                });

            migrationBuilder.CreateTable(
                name: "ProductosRequeridos",
                columns: table => new
                {
                    IdProductoRequerido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    IdRequerimiento = table.Column<int>(type: "int", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosRequeridos", x => x.IdProductoRequerido);
                    table.ForeignKey(
                        name: "FK_ProductosRequeridos_Productos_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductosRequeridos_Requerimientos_IdRequerimiento",
                        column: x => x.IdRequerimiento,
                        principalTable: "Requerimientos",
                        principalColumn: "IdRequerimiento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductosRequeridos_IdProducto",
                table: "ProductosRequeridos",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosRequeridos_IdRequerimiento",
                table: "ProductosRequeridos",
                column: "IdRequerimiento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductosRequeridos");

            migrationBuilder.DropTable(
                name: "Requerimientos");
        }
    }
}
