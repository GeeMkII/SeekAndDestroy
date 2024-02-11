
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using SAD.App.Mappings;
using SAD.App.Services;
using SAD.App.Warehause;

namespace SAD.App.Eztensions
{//Dodanie zależnosci
    public static class SeviceCollectionExt
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IWarehauseService, WarehauseService>();
            services.AddAutoMapper(typeof(WarehauseMappingProfile));

            services.AddValidatorsFromAssemblyContaining<WarehauseDtoVaildator>().AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
        }
    }
}
