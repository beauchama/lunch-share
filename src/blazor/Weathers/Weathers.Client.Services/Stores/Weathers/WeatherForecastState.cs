using Fluxor;
using Weathers.Shared.Resources;

namespace Weathers.Client.Services.Stores.Weathers;

[FeatureState]
public record WeatherForecastState
{
    private WeatherForecastState() { }

    private WeatherForecastState(IEnumerable<WeatherForecast>? weatherForecasts, bool isLoading)
    {
        WeatherForecasts = weatherForecasts?.ToArray() ?? Array.Empty<WeatherForecast>();
        IsLoading = isLoading;
    }

    public IReadOnlyCollection<WeatherForecast> WeatherForecasts { get; } = Array.Empty<WeatherForecast>();

    public bool IsLoading { get; }

    public static WeatherForecastState MakeStateWith(IEnumerable<WeatherForecast>? weatherForecasts, bool isLoading = false) => new(weatherForecasts, isLoading);

    public static WeatherForecastState MakeLoadingState() => new(null, true);
}
