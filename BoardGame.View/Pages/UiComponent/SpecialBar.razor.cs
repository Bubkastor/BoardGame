using BoardGame.Models.PlayerState;
using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages.UiComponent;

public partial class SpecialBar : ComponentBase
{
    [Parameter]
    public required SPECIAL Special { get; set; }

    [Parameter] 
    public required Experience Exp { get; set; }
}