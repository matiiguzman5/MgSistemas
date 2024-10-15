using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MgSistemas.Migrations
{
    /// <inheritdoc />
    public partial class AddFechaUltimaModificacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaUltimaModificacion",
                table: "Productos",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaUltimaModificacion",
                table: "Productos");
        }
    }
}
