using System.Reflection;
using Weathers.Client;

namespace BlazorLunchShare.Client;

public partial class App
{
    private readonly Assembly[] additionalAssemblies = new[]
    {
        typeof(WeathersPage).Assembly
    };
}
