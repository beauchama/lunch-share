using Weathers.Persistence.Dto;

namespace Weathers.Persistence.Repositories;

public interface IWeatherForecastRepository
{
    public IEnumerable<WeatherForecastDto> GetAllWeatherForecasts();
}
