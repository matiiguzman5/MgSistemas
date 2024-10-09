using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MgSistemas
{

    public class PanolContext : DbContext
    {
        public DbSet <Producto> Productos { get; set; }

        public DbSet<Movimiento> movimientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MgSistemas;Database=MgSistemasDb;User Id=MgSistConnection;Password=MgSist2024;");

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
           
        }

        public class Movimiento
        {
            [Key]
            public int IdMovimiento { get; set; }
            public int IdProducto { get; set; }
            public string TipoMovimiento { get; set; } // "Entrada" o "Salida"
            public int Cantidad { get; set; }
            public DateTime FechaMovimiento { get; set; }
            public string Usuario { get; set; }

            public Producto Producto { get; set; }
        }

    }
}
