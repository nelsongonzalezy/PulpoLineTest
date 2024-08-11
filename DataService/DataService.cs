using DataService.Service;
using Microsoft.Extensions.DependencyInjection;

namespace DataService
{
    public static class DataService
    {
        public static IServiceCollection InitializerDataService(this IServiceCollection services)=>
            services.AddScoped<ICarbonEmission, CarbonEmissionService>();
    }
}
