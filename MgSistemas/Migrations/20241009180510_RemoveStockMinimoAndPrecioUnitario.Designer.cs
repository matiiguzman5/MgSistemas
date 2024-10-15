﻿// <auto-generated />
using System;
using MgSistemas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MgSistemas.Migrations
{
    [DbContext(typeof(PanolContext))]
    [Migration("20241009180510_RemoveStockMinimoAndPrecioUnitario")]
    partial class RemoveStockMinimoAndPrecioUnitario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MgSistemas.PanolContext+Movimiento", b =>
                {
                    b.Property<int>("IdMovimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMovimiento"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaMovimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("ProductoIdProducto")
                        .HasColumnType("int");

                    b.Property<string>("TipoMovimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMovimiento");

                    b.HasIndex("ProductoIdProducto");

                    b.ToTable("movimientos");
                });

            modelBuilder.Entity("MgSistemas.PanolContext+Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockActual")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.ToTable("producto");
                });

            modelBuilder.Entity("MgSistemas.PanolContext+Movimiento", b =>
                {
                    b.HasOne("MgSistemas.PanolContext+Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoIdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}
