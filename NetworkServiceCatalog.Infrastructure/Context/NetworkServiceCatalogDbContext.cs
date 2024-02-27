using Microsoft.EntityFrameworkCore;
using NetworkServiceCatalog.Domain.Entities;

namespace NetworkServiceCatalog.Infrastructure.Context
{
    public class NetworkServiceCatalogDbContext : DbContext 
    {
        public NetworkServiceCatalogDbContext(DbContextOptions<NetworkServiceCatalogDbContext> options) : base(options)
        {
            
        }

        public DbSet<Location> Locations { get; set; }
    }
}
