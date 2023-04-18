using Microsoft.AspNetCore.Components;

namespace BlazorLunchShare.Client.Pages;

public partial class Details
{
    [Parameter]
    public int Id { get; set; }

    [Parameter]
    [SupplyParameterFromQuery]
    public string Name { get; set; } = default!;
}
