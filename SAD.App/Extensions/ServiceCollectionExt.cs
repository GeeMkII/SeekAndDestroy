

// Ignore Spelling: App
using MediatR;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using SAD.App.Mappings;
using SAD.App.Warehouse.Commands.CreateWareHouse;

namespace SAD.App.Extensions
{//Dodanie zależnosci
    public static class ServiceCollectionExt
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateWareHouseCmd));

            services.AddAutoMapper(typeof(WarehouseMappingProfile));

            services.AddValidatorsFromAssemblyContaining<CreateWarehouseCmdVaildator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
        }
    }
}
