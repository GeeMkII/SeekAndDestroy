

using SAD.App.Warehouse;

namespace SAD.App.Services
{
    public interface IWarehouseService
    {
        Task Create(Domain.Entities.Warehouse warehause);
        Task<IEnumerable<WarehouseDto>> GetAll();

    }
}