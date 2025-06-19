using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages.UiComponent;

public partial class HpBar : ComponentBase
{
    public int MaxHp { get; } = 16;
    [Parameter]
    public required int CurrentHp { get; set; }
    [Parameter]
    public required int CurrentRadiation { get; set; }
    
}