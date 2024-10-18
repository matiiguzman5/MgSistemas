using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MgSistemas
{

    public class PanolContext : DbContext
    {
        public DbSet <Producto> Productos { get; set; }

        public DbSet<Movimiento> Movimientos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Requerimiento> Requerimientos{ get; set; }

        public DbSet<ProductoRequerido> ProductosRequeridos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);Database=MgSistemasDb;Integrated Security=True;TrustServerCertificate=True;");

        }
               
        public class Producto
        {
            [Key]
            public int IdProducto { get; set; }

            public int CodigoProducto { get; set; }
            public string Nombre { get; set; }

            public string Descripcion { get; set; }
            public string Categoria { get; set; }
            public int StockActual { get; set; }

            public DateTime FechaIngreso { get; set; }
            public DateTime? FechaUltimaModificacion { get; set; }

            public ICollection<Movimiento> Movimientos { get; set; }
        }


        public class Usuario
        {
            [Key]
            public int IdUsuario { get; set; }
            public string NombreUsuario { get; set; }
            public string Contrasenia { get; set; }
            public string NombreCompleto { get; set; }
            public string Rol { get; set; }
            public DateTime FechaCreacion { get; set; }
            public bool Activo { get; set; }
        }


        public class Movimiento
        {
            [Key]
            public int IdMovimiento { get; set; }

            public int? IdProducto { get; set; } // Permitir valores nulos

            public string TipoMovimiento { get; set; }
            public int Cantidad { get; set; }
            public DateTime FechaMovimiento { get; set; }
            public string Usuario { get; set; }
            public string Detalles { get; set; }

            public Producto Producto { get; set; }
        }

        public class Requerimiento
        {
            [Key]
            public int IdRequerimiento { get; set; }

            public int NroRequerimiento { get; set; }
            public string Responsable { get; set; }

            public DateTime FechaSolicitud { get; set; }

            public string Observaciones { get; set; }

            public string Prioridad { get; set; }

            public DateTime FechaEntrega { get; set; }

            public ICollection<ProductoRequerido> Productos { get; set; }
        }

        public class ProductoRequerido
        {
            [Key]
            public int IdProductoRequerido { get; set; }

            public int Cantidad { get; set; }

            [ForeignKey("Requerimiento")]
            public int IdRequerimiento { get; set; }

            public Requerimiento Requerimiento { get; set; }

            [ForeignKey("Producto")]
            public int IdProducto { get; set; }

            public Producto Producto { get; set; }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movimiento>()
                .HasOne(m => m.Producto)
                .WithMany(p => p.Movimientos)
                .HasForeignKey(m => m.IdProducto)
                .OnDelete(DeleteBehavior.SetNull); // Establecer a NULL cuando se elimine el producto
        }

    }

}