using Microsoft.Extensions.DependencyInjection;
using Weathers.Domain.Services;
using Weathers.Persistence;

namespace Weathers.Domain;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWeathersDomain(this IServiceCollection services)
    {
        return services
            .AddTransient<IWeatherForecastService, WeatherForecastService>()
            .AddWeathersPersistence();
    }
}
