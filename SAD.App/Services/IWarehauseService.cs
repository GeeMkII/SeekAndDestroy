

using SAD.App.Warehause;

namespace SAD.App.Services
{
    public interface IWarehauseService
    {
        Task Create(WarehauseDto warehause);
        Task<IEnumerable<WarehauseDto>> GetAll();

    }
}