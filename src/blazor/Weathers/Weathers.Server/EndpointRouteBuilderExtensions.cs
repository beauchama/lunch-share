using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Weathers.Shared;

namespace Weathers.Server;

public static class EndpointRouteBuilderExtensions
{
    public static IEndpointRouteBuilder MapWeatherForecastEndpoint(this IEndpointRouteBuilder builder)
    {
        var endpoint = builder.MapGroup(WeatherForecastEndpointRoute.WeatherForecastEndpoint);

        endpoint.MapGet("/", WeatherForecastEndpoint.GetAllWeatherForecasts);

        return endpoint;
    }
}
