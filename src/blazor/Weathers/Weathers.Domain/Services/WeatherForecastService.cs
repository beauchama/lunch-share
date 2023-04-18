using Weathers.Domain.Entities;
using Weathers.Domain.Mappers;
using Weathers.Persistence.Repositories;

namespace Weathers.Domain.Services;

internal sealed class WeatherForecastService(IWeatherForecastRepository weatherForecastRepository) : IWeatherForecastService
{
    public IEnumerable<WeatherForecastEntity> GetAllWeatherForecasts() => weatherForecastRepository.GetAllWeatherForecasts().ToEntities();
}
