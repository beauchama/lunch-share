using Fluxor;
using Weathers.Client.Services.Stores.Weathers.Actions;

namespace Weathers.Client.Services.Stores.Weathers;

public static class WeatherForecastsReducers
{
    [ReducerMethod(typeof(GetAllWeatherForecastsAction))]
    public static WeatherForecastState ReduceGetAllWeatherForecastsAction(WeatherForecastState state)
        => WeatherForecastState.MakeLoadingState();

    [ReducerMethod]
    public static WeatherForecastState ReduceGetAllWeatherForecastsResultAction(WeatherForecastState state, GetAllWeatherForecastsResultAction action)
        => WeatherForecastState.MakeStateWith(action.WeatherForecasts);
}
