using Microsoft.Extensions.DependencyInjection;

namespace Weathers.Client.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWeathersClientServices(this IServiceCollection services, string baseAddress)
    {
        services.AddHttpClient<IWeathersHttpClient, WeathersHttpClient>(http => http.BaseAddress = new Uri(baseAddress));

        return services;
    }
}
