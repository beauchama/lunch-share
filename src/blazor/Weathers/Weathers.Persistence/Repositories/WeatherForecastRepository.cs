using Weathers.Persistence.Dto;

namespace Weathers.Persistence.Repositories;

internal sealed class WeatherForecastRepository : IWeatherForecastRepository
{
    private readonly WeatherForecastDto[] weatherForecasts;

    public WeatherForecastRepository()
    {
        weatherForecasts = Enumerable.Range(1, 10).Select(_ =>
        {
            int temperature = Random.Shared.Next(-40, 40);

            return new WeatherForecastDto
            {
                Date = DateTime.Now,
                TemperatureC = temperature,
                Summary = temperature switch
                {
                    -40 => "Freezing",
                    > -40 and < -20 => "Bracing",
                    > -20 and < -10 => "Chilly",
                    > -10 and < 0 => "Cool",
                    > 0 and < 10 => "Mild",
                    > 10 and < 20 => "Warm",
                    > 20 and < 30 => "Hot",
                    _ => "Scorching"
                }
            };
        }).ToArray();
    }

    public IEnumerable<WeatherForecastDto> GetAllWeatherForecasts() => weatherForecasts;
}
