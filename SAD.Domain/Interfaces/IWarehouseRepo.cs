namespace SAD.Domain.Interfaces
{
    public interface IWarehouseRepo
    {
        Task Create(Domain.Entities.Warehouse warehause);
        Task<Entities.Warehouse?> GetBySeo(string seo);
        Task<IEnumerable<Entities.Warehouse>> GetAll();
       // Task Dellete(string seo);
    }
}
