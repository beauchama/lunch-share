using Weathers.Domain.Entities;

namespace Weathers.Domain.Services;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecastEntity> GetAllWeatherForecasts();
}
