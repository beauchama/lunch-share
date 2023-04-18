using Weathers.Shared.Resources;

namespace Weathers.Client.Services.Stores.Weathers.Actions;

public sealed record GetAllWeatherForecastsResultAction(IEnumerable<WeatherForecast> WeatherForecasts);