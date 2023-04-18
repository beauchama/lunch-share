using Microsoft.AspNetCore.Http;
using Weathers.Domain.Services;
using Weathers.Server.Mappers;
using Weathers.Shared.Resources;

namespace Weathers.Server;

public static class WeatherForecastEndpoint
{
    public static IResult GetAllWeatherForecasts(IWeatherForecastService service)
        => Results.Ok(service.GetAllWeatherForecasts().ToApiResources());
}
