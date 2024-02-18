// Ignore Spelling: Repo Seo

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

        public Task Commit()
            => _dbContext.SaveChangesAsync();

        public async Task<IEnumerable<Warehouse>> GetAll()        
            => await _dbContext.Warehouses.ToListAsync();


        public Task<Warehouse?> GetBySeo(string seo) => _dbContext.Warehouses.FirstAsync(cw => cw.SEOName == seo);
    }
}
