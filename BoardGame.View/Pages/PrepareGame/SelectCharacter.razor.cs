using BoardGame.Models.PlayerState;
using BoardGame.Models.View;
using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages.PrepareGame;


//todo добавить взаимоисключающий список персонажей
// private IEnumerable<string> AvailableItems1 => 
// AllItems.Except(new[] { SelectedItem2 }.Where(x => !string.IsNullOrEmpty(x)));
public partial class SelectCharacter : ComponentBase
{
    [Parameter]
    public required EventCallback SetStep { get; set; }

    [Parameter]
    public required int PlayerCount { get; set; }

    private List<PlayerView> playerViews;
    private Players players = new();

    protected override async Task OnInitializedAsync()
    {
        playerViews = new List<PlayerView>();
        for (int i = 0; i < PlayerCount; i++)
        {
            playerViews.Add(new());
        }
        StateHasChanged();
        await base.OnInitializedAsync();
    }

    protected async Task NextScreen()
    {
        await SetStep.InvokeAsync();
    }
    private class PlayerView
    {
        public string Name { get; set; }
        public PlayerType Type { get; set; }
    }

}