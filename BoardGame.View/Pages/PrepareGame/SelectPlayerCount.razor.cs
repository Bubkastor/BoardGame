using BoardGame.Models;
using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages.PrepareGame;

public partial class SelectPlayerCount : ComponentBase
{
    [Parameter]
    public required EventCallback SetStep { get; set; }
    [Parameter]
    public required EventCallback<int> SetPLayersCount { get; set; }


    protected async Task NextScreen()
    {
        await SetPLayersCount.InvokeAsync(1);
        await SetStep.InvokeAsync();
    }
}