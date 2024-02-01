﻿
using Microsoft.Extensions.DependencyInjection;
using SAD.App.Mappings;
using SAD.App.Services;
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
            services.AddScoped<IWarehouseService, WarehouseService>();
            services.AddAutoMapper(typeof(WarehouseMappingProfile));
        }
    }
}