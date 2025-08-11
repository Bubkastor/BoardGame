using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages.Game;

public partial class Game : ComponentBase
{
    [Parameter]
    public string IdGame { get; set; }
}