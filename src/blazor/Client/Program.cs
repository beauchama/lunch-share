using BlazorLunchShare.Client;
using Fluxor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Weathers.Client.Services;
using Weathers.Client.Services.Stores.Weathers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddWeathersClientServices(builder.HostEnvironment.BaseAddress);
builder.Services.AddFluxor(options => options.ScanAssemblies(typeof(WeatherForecastState).Assembly));

await builder.Build().RunAsync();
