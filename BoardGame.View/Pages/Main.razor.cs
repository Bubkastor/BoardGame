using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages;

public partial class Main: ComponentBase
{
    [Parameter]
    public required EventCallback SetStep { get; set; }

    protected async Task NextScreen()
    {
        await SetStep.InvokeAsync();
    }
}