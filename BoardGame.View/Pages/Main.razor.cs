using Microsoft.AspNetCore.Components;
using BoardGame.Models;
using BoardGame.View.Services;

namespace BoardGame.View.Pages;

public partial class Main: ComponentBase
{
    [Inject]
    protected BrowserStorageService Storage { get; init; }

    [Parameter]
    public required EventCallback SetStep { get; set; }
    [Parameter]
    public required EventCallback<string> SetStepContinue { get; set; }

    public ScenarioType ScenarioType { get; set; }
    public int PlayersCount { get; set; }

    private string idGame = string.Empty;
    private bool disableContinue = true;
    private static string ID_GAME_KEY = "ID_GAME_KEY";

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        idGame = await Storage.GetItem<string>(ID_GAME_KEY);
        if (!string.IsNullOrEmpty(idGame))
        {
            disableContinue = false;
        }
        StateHasChanged();
        await base.OnAfterRenderAsync(firstRender);
    }
    
    protected async Task NextScreen()
    {
        await SetStep.InvokeAsync();
    }
    protected async Task ContinueGame()
    {
        await SetStepContinue.InvokeAsync(idGame);
    }
}