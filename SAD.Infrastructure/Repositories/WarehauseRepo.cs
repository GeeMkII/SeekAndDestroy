using Microsoft.EntityFrameworkCore;
using SAD.Domain.Entities;
using SAD.Domain.Interfaces;
using SAD.Infrastructure.DB;

namespace SAD.Infrastructure.Repositories
{
    internal class WarehauseRepo : IWarehauseRepo
    {
        private readonly SaDDbContext _dbContext;
        public WarehauseRepo(SaDDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(Domain.Entities.Warehause warehause)
        {
            _dbContext.Add(warehause);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Warehause>> GetAll()        
            => await _dbContext.Warehauses.ToListAsync();
        

        public Task<Warehause?> GetBySeo(string seo)
        {
            throw new NotImplementedException();
        }
    }
}
