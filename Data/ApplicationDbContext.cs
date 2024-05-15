using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace replicaPROGRAMA.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}
            public DbSet<replicaPROGRAMA.Models.Contacto> DataContacto {get; set; }
            public DbSet<replicaPROGRAMA.Models.Producto> DataProducto {get; set; }
            public DbSet<replicaPROGRAMA.Models.Proforma> DataItemCarrito {get; set; }
            public DbSet<replicaPROGRAMA.Models.Pago> DataPago {get; set; }
            public DbSet<replicaPROGRAMA.Models.Pedido> DataPedido {get; set; }
            public DbSet<replicaPROGRAMA.Models.DetallePedido> DataDetallePedido {get; set; }
}
