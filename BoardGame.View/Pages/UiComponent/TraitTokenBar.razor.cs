using BoardGame.Models.PlayerState;
using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages.UiComponent;

public partial class TraitTokenBar : ComponentBase
{
    private const int COUNT_TRAIT_TOKEN = 3;
    [Parameter]
    public required List<TraitTokenType> TraitTokens { get; set; }

    public string GetTraitToken(int i)
    {
        if (TraitTokens.Count > i)
            return TraitTokens[i].ToString();
        else
            return string.Empty;
    }
}