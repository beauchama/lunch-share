using Microsoft.AspNetCore.Components;

namespace BlazorLunchShare.Client.Components;

public partial class CounterComponent
{
    private int currentCount = 0;

    [Parameter]
    [EditorRequired]
    public int InitialCount { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        currentCount = InitialCount;
    }

    private void IncrementCount()
    {
        currentCount++;
    }
}
