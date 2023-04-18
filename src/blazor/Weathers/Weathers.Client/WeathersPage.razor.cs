using Fluxor;
using Microsoft.AspNetCore.Components;
using Weathers.Client.Services.Stores.Weathers;
using Weathers.Client.Services.Stores.Weathers.Actions;

namespace Weathers.Client;

public partial class WeathersPage
{
    private bool isDisposed;
    private int count = 0;

    [Inject]
    private IState<WeatherForecastState> WeatherForecastState { get; set; } = default!;

    [Inject]
    private IDispatcher Dispatcher { get; set; } = default!;

    [Inject]
    private IActionSubscriber ActionSubscriber { get; set; } = default!;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Dispatcher.Dispatch(new GetAllWeatherForecastsAction());

        ActionSubscriber.SubscribeToAction<GetAllWeatherForecastsResultAction>(this, action =>
        {
            action.WeatherForecasts.TryGetNonEnumeratedCount(out int nonEnumeratedCount);
            count = nonEnumeratedCount;
        });
    }

    protected override void Dispose(bool disposing)
    {
        if (isDisposed)
        {
            return;
        }

        base.Dispose(disposing);

        if (disposing)
        {
            ActionSubscriber.UnsubscribeFromAllActions(this);
        }

        isDisposed = true;
    }
}
