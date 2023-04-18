using Fluxor;
using Weathers.Client.Services.Stores.Weathers.Actions;
using Weathers.Shared.Resources;

namespace Weathers.Client.Services.Stores.Weathers;

public sealed class WeatherForecastsEffect(IWeathersHttpClient weathersHttpClient)
{
    [EffectMethod(typeof(GetAllWeatherForecastsAction))]
    public async Task HandleGetAllWeatherForecastsActionAsync(IDispatcher dispatcher)
    {
        IEnumerable<WeatherForecast> weatherForecasts = await weathersHttpClient.GetAllWeatherForecastsAsync();

        dispatcher.Dispatch(new GetAllWeatherForecastsResultAction(weatherForecasts));
    }
}
