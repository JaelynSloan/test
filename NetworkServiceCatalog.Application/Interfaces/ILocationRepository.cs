using NetworkServiceCatalog.Domain.Entities;

namespace NetworkServiceCatalog.Application.Interfaces
{
    public interface ILocationRepository
    {
        Task AddAsync(Location location);

        Task <List<Location>> GetAllAsync();   
    }
}
