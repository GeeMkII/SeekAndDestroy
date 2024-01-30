using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD_Infrastructure.Data
{
    internal class SadDBContext : DbContext
    { 
        public DbSet<SAD_Domain.Entities.SeekAndDestroy> destroys {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;DB-SaD;Trusted_Connection-True;");
        }
    }
}
