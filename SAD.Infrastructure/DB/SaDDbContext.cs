using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Infrastructure.DB
{
    public class SaDDbContext : DbContext
    {
        public SaDDbContext(DbContextOptions<SaDDbContext> options) :  base(options) 
        {
            
        }
        public DbSet<SAD.Domain.Entities.Warehause> Warehauses { get; set;}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WarehauseDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Warehause>().OwnsOne(c => c.PalletRack);
        }
    }
}
