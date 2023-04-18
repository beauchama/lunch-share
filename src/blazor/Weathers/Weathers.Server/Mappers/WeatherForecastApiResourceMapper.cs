using Weathers.Domain.Entities;
using Weathers.Shared.Resources;

namespace Weathers.Server.Mappers;

internal static class WeatherForecastApiResourceMapper
{
    internal static IEnumerable<WeatherForecast> ToApiResources(this IEnumerable<WeatherForecastEntity> entities) => entities.Select(ToApiResource);

    private static WeatherForecast ToApiResource(this WeatherForecastEntity entity) => new()
    {
        Date = entity.Date,
        Summary = entity.Summary,
        TemperatureInCelsius = entity.TemperatureInCelsius,
        TemperatureInFahrenheit = entity.TemperatureInFahrenheit
    };
}
