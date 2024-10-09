using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MgSistemas
{

    public class PanolContext : DbContext
    {
        public DbSet <Producto> productos { get; set; }

        public DbSet<Movimientos> Movimientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("")
        }

    }
    
    
}
