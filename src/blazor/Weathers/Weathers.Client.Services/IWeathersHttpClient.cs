using Weathers.Shared.Resources;

namespace Weathers.Client.Services;

public interface IWeathersHttpClient
{
    Task<IEnumerable<WeatherForecast>> GetAllWeatherForecastsAsync();
}
