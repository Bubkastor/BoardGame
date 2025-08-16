using BoardGame.Models;
using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages.PrepareGame;

public partial class SelectPlayerCount : ComponentBase
{
    [Parameter]
    public required EventCallback SetStep { get; set; }
    [Parameter]
    public required EventCallback<int> SetPlayersCount { get; set; }

    private int PlayerCount = 1;

    protected async Task NextScreen()
    {
        await SetPlayersCount.InvokeAsync(PlayerCount);
        await SetStep.InvokeAsync();
    }
}