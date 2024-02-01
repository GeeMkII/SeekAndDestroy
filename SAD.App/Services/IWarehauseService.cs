

using SAD.App.Warehause;

namespace SAD.App.Services
{
    public interface IWarehauseService
    {
        Task Create(Domain.Entities.Warehause warehause);
        Task<IEnumerable<WarehauseDto>> GetAll();

    }
}