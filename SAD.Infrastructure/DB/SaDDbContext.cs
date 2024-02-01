using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace SAD.Infrastructure.DB
{
    public class SaDDbContext : DbContext
    {
        public SaDDbContext(DbContextOptions<SaDDbContext> options) :  base(options) 
        {
            var firstDbTablesCreate = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
            if (!firstDbTablesCreate.CanConnect())
            {
                firstDbTablesCreate.Create();
            }

            if (!firstDbTablesCreate.HasTables())
            {
                firstDbTablesCreate.CreateTables();
            }
        }
        public DbSet<SAD.Domain.Entities.Warehause> Warehauses { get; set;}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionDB"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Warehause>().OwnsOne(c => c.PalletRack);
        }
    }
}
