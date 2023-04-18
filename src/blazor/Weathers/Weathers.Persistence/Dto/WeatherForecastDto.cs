namespace Weathers.Persistence.Dto;

public sealed record WeatherForecastDto
{
    public DateTime Date { get; init; }

    public int TemperatureC { get; init; }

    public string? Summary { get; init; }
}
