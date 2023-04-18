using Weathers.Domain.Entities;
using Weathers.Persistence.Dto;

namespace Weathers.Domain.Mappers;

internal static class WeatherForecastEntityMapper
{
    internal static WeatherForecastEntity ToEntity(this WeatherForecastDto dto) => new()
    {
        Date = DateOnly.FromDateTime(dto.Date),
        Summary = dto.Summary,
        TemperatureInCelsius = dto.TemperatureC,
        TemperatureInFahrenheit = 32 + (int)(dto.TemperatureC / 0.5556)
    };

    internal static IEnumerable<WeatherForecastEntity> ToEntities(this IEnumerable<WeatherForecastDto> dto) => dto.Select(ToEntity);
}
