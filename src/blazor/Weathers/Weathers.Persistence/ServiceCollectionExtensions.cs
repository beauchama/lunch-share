using Microsoft.Extensions.DependencyInjection;
using Weathers.Persistence.Repositories;

namespace Weathers.Persistence;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWeathersPersistence(this IServiceCollection services)
        => services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
}
