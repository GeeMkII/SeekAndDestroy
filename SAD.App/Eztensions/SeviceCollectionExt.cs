
using Microsoft.Extensions.DependencyInjection;
using SAD.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Eztensions
{//Dodanie zależnosci
    public static class SeviceCollectionExt
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IWarehauseService, WarehauseService>();
        }
    }
}
