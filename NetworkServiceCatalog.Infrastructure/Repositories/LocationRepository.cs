using Microsoft.EntityFrameworkCore;
using NetworkServiceCatalog.Application.Interfaces;
using NetworkServiceCatalog.Domain.Entities;
using NetworkServiceCatalog.Infrastructure.Context;

namespace NetworkServiceCatalog.Infrastructure.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly NetworkServiceCatalogDbContext context;

        public LocationRepository(IDbContextFactory<NetworkServiceCatalogDbContext> factory) {
            context = factory.CreateDbContext();
        }

        public async Task AddAsync(Location location)
        {
            context.Locations.Add(location);
            await context.SaveChangesAsync();
        }

        public async Task<List<Location>> GetAllAsync()
        {
            var locations = await context.Locations.ToListAsync();
            return locations;
        }
    }
}
