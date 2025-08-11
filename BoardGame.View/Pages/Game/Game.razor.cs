using BoardGame.Models;
using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages.Game;

public partial class Game : ComponentBase
{
    [Parameter] public string IdGame { get; set; }
    [Parameter] public ScenarioType ScenarioType { get; set; }
    [Parameter] public int PlayersCount { get; set; }
    
}