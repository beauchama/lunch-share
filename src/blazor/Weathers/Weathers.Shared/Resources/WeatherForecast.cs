namespace Weathers.Shared.Resources;

public sealed record WeatherForecast
{
    public DateOnly Date { get; init; }

    public int TemperatureInCelsius { get; init; }

    public int TemperatureInFahrenheit { get; init; }

    public string? Summary { get; init; }
}
