namespace SAD.Domain.Interfaces
{
    public interface IWarehauseRepo
    {
        Task Create(Domain.Entities.Warehause warehause);
        Task<Entities.Warehause?> GetBySeo(string seo);
        Task<IEnumerable<Entities.Warehause>> GetAll();
       // Task Dellete(string seo);
    }
}
