using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public class ECommerceContext:DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options): base(options)
        { 
        
        }
        //public DbSet<ECommerce.Models.Producto> Producto { get; set; }
        //public DbSet<ECommerce.Models.Pedido> Pedido { get; set; }

        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        //public virtual DbSet<Factura> Facturas { get; set; }

    }
}
