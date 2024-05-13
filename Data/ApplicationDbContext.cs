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
    
}
