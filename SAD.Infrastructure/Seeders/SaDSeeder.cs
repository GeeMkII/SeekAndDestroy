using SAD.Domain.Entities;
using SAD.Infrastructure.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Infrastructure.Seeders
{
    public class SaDSeeder
    {
        private readonly SaDDbContext _dbContext;

        public SaDSeeder(SaDDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if(!_dbContext.Warehauses.Any())
                {
                    var p1 = new Domain.Entities.Warehause() //pozycja na stojaku p-przód s-środek t-tył. Numery = piętra.
                    {
                        Hardnes = "S355",
                        Width = 200,
                        Height = 4000,
                        Thicness = 8,
                        PalletRack = new()
                        {
                            Name ="Namiot"
                        }

                    };
                    p1.SeoName();

                    var s1 = new Domain.Entities.Warehause()
                    {
                        Hardnes = "S355",
                        Width = 400,
                        Height = 3000,
                        Thicness = 10,
                        PalletRack = new()
                        {
                            Name = "Namiot"
                        }

                    };
                    s1.SeoName();

                    var t1 = new Domain.Entities.Warehause()
                    {
                        Hardnes = "S355",
                        Width = 222,
                        Height = 3333,
                        Thicness = 12,
                        Description = "Odpad",
                        PalletRack = new()
                        {
                            Name = "Namiot"
                        }

                    };
                    t1.SeoName();
                   
                    _dbContext.Warehauses.AddRange(p1,s1,t1);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
