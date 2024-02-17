using Microsoft.EntityFrameworkCore;
using SAD.Domain.Entities;
using SAD.Domain.Interfaces;
using SAD.Infrastructure.DB;

namespace SAD.Infrastructure.Repositories
{
    internal class WarehouseRepo : IWarehouseRepo
    {
        private readonly SaDDbContext _dbContext;
        public WarehouseRepo(SaDDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(Warehouse warehouse)
        {
            _dbContext.Add(warehouse);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Warehouse>> GetAll()        
            => await _dbContext.Warehouses.ToListAsync();
        

        public Task<Warehouse?> GetBySeo(string seo)
        {
            throw new NotImplementedException();
        }
    }
}
