using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Frozen;

namespace BlazorLunchShare.Client.Pages;

public partial class Colors
{
    [Inject]
    private IJSRuntime JsRuntime { get; set; } = default!;

    private IEnumerable<SubColor> subColors = Array.Empty<SubColor>();
    private int selectedColor;

    private readonly FrozenDictionary<Color, IEnumerable<SubColor>> ColorsToPick = new Dictionary<Color, IEnumerable<SubColor>>
    {
        { new Color(1, "Red"), new[] { new SubColor("D0312D", "Cherry"), new SubColor("B90E0A", "Crimson") } },
        { new Color(2, "Green"), new[] { new SubColor("AEF359", "Lime"), new SubColor("98BF64", "Olive") } },
        { new Color(3, "Blue"), new[] { new SubColor("00FFFF", "Cyan"), new SubColor("00008B", "Dark blue") } },
    }.ToFrozenDictionary();

    private void OnColorChange() => subColors = ColorsToPick.First(c => c.Key.Id == selectedColor).Value;

    private async Task OnSubColorChangeAsync(ChangeEventArgs args)
    {
        string subColorCode = args.Value!.ToString()!;
        await JsRuntime.InvokeVoidAsync("changeColor", subColorCode);
    }

    private sealed record Color(int Id, string Name);

    private sealed record SubColor(string Code, string Name);
}
