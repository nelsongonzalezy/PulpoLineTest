using Core.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public static class Core
    {
        public static IServiceCollection InitializerCoreDataService(this IServiceCollection services) =>
        services.AddScoped<ICarbonEmissionDbService, CarbonEmissionDbService>();

    }
}
