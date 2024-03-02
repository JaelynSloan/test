using NetworkServiceCatalog.Domain.Entities;

namespace NetworkServiceCatalog.Application.Interfaces
{
    public interface ILocationRepository
    {
        Task AddAsync(Location location);

        Task<List<Location>> GetAllAsync();   

        Task<Location?> GetByIdAsync(int id);

        Task UpdateAsync(Location location);
    }
}
