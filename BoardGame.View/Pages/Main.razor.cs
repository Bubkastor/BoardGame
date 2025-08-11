using Microsoft.AspNetCore.Components;
using Blazor.Extensions.Storage;
using BoardGame.Models;

namespace BoardGame.View.Pages;

public partial class Main: ComponentBase
{
    [Inject]
    private LocalStorage LocalStorage { get; set; }

    [Parameter]
    public required EventCallback SetStep { get; set; }
    [Parameter]
    public required EventCallback<string> SetStepContinue { get; set; }

    public ScenarioType ScenarioType { get; set; }
    public int PlayersCount { get; set; }

    private string idGame = string.Empty;
    private bool disableContinue = true;
    private static string ID_GAME_KEY = "ID_GAME_KEY";

    protected override async Task OnInitializedAsync()
    {
        idGame = await LocalStorage.GetItem<string>(ID_GAME_KEY);
        if (!string.IsNullOrEmpty(idGame))
        {
            disableContinue = false;
        }
        await base.OnInitializedAsync();
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