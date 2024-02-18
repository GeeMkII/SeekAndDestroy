

// Ignore Spelling: App

using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using SAD.App.Mappings;
using SAD.App.Services;
using SAD.App.Warehouse;

namespace SAD.App.Extensions
{//Dodanie zależnosci
    public static class ServiceCollectionExt
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IWarehouseService, WarehouseService>();

            services.AddAutoMapper(typeof(WarehouseMappingProfile));

            services.AddValidatorsFromAssemblyContaining<WarehouseDtoVaildator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
        }
    }
}
