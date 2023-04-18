namespace Weathers.Domain.Entities;

public sealed record WeatherForecastEntity
{
    public DateOnly Date { get; init; }

    public int TemperatureInCelsius { get; init; }

    public int TemperatureInFahrenheit { get; init; }

    public string? Summary { get; init; }
}
