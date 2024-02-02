
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SAD.App.Mappings;
using SAD.App.Warehouse.Comands.CretaPlates;
using SAD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Eztensions
{//Dodanie zależnosci
    public static class ServiceCollectionExt
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreatePlatesCmd));
            services.AddAutoMapper(typeof(WarehouseMappingProfile));
        }
    }
}
