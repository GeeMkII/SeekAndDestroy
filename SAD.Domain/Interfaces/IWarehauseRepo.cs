// Ignore Spelling: Repo

namespace SAD.Domain.Interfaces
{
    public interface IWarehouseRepo
    {
        Task Create(Entities.Warehouse warehouse);
        Task<Entities.Warehouse?> GetBySeo(string seo);
        Task<IEnumerable<Entities.Warehouse>> GetAll();
        Task Commit();
       // Task Dellete(string seo);
    }
}
