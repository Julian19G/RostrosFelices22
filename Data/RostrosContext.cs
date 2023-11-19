using Microsoft.EntityFrameworkCore;
using RostrosFelices.Models;

namespace RostrosFelices.Data
{
    public class RostrosContext : DbContext
    {
        public RostrosContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }

    }
}
