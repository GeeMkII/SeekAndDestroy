using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SAD.Domain.Interfaces;
using SAD.Infrastructure.DB;
using SAD.Infrastructure.Repositories;
using SAD.Infrastructure.Seeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Infrastructure.Extensions
{
    public static class ServiceColectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SaDDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Warehouse")));

            services.AddScoped<SaDSeeder>();
            services.AddScoped<IWarehouseRepo, WarehouseRepo>();
        }
    }
}
