


// Ignore Spelling: App

using SAD.App.Warehouse;

namespace SAD.App.Services
{
    public interface IWarehouseService
    {
        Task Create(WarehouseDto warehouse);
        Task<IEnumerable<WarehouseDto>> GetAll();

    }
}