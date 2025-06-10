using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages.PrepareGame;

public partial class SelectPlayerCount : ComponentBase
{
    [Parameter]
    public required EventCallback SetStep { get; set; }

    protected async Task NextScreen()
    {
        await SetStep.InvokeAsync();
    }
}