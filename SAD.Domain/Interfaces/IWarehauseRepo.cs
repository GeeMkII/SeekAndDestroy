namespace SAD.Domain.Interfaces
{
    public interface IWarehauseRepo
    {
        Task Create(Domain.Entities.Warehause warehause);
    }
}
