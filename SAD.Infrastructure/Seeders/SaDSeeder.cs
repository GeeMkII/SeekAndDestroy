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
                if( !_dbContext.Warehouses.Any()  )
                {
                    var p1 = new Warehouse() //pozycja na stojaku p-przód s-środek t-tył. Numery = piętra.
                    {
                        Hardness = "S355",
                        Width = 200,
                        Height = 4000,
                        Thickness = 8,
                        PalletRack = new()

                        {
                            Name ="Namiot",
                            Position = "p1"
                            
                        }

                    };
                    p1.SeoName();

                    var s1 = new Domain.Entities.Warehouse()
                    {
                        Hardness = "S355",
                        Width = 400,
                        Height = 3000,
                        Thickness = 10,
                        PalletRack = new()
                        {
                            Name = "Namiot",
                            Position = "p1"                           
                        }

                    };
                    s1.SeoName();

                    var t1 = new Domain.Entities.Warehouse()
                    {
                        Hardness = "S355",
                        Width = 222,
                        Height = 3333,
                        Thickness = 12,
                        Description = "Odpad",
                        PalletRack = new()
                        {
                            Name = "Namiot",
                            Position = "p1"
                        }

                    };
                    t1.SeoName();
                   
                    _dbContext.Warehouses.AddRange(p1,s1,t1);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
