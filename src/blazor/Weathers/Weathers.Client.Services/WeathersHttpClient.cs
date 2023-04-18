using System.Net.Http.Json;
using Weathers.Shared;
using Weathers.Shared.Resources;

namespace Weathers.Client.Services;

internal sealed class WeathersHttpClient(HttpClient client) : IWeathersHttpClient
{
    public async Task<IEnumerable<WeatherForecast>> GetAllWeatherForecastsAsync()
        => (await client.GetFromJsonAsync<IEnumerable<WeatherForecast>>(WeatherForecastEndpointRoute.WeatherForecastEndpoint))!;
}
