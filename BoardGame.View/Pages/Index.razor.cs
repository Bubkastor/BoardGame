using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages;

public partial class Index
{
    public PrepareStep CurrentStep { get; private set; } = PrepareStep.None;
    public bool IsLoadGame = false;
    public string IdGame = string.Empty;
        
    public enum PrepareStep
    {
        None = 0,
        Scenario,
        PlayerCount,
        Character
    }

    public void SetStep(PrepareStep step)
    {
        CurrentStep = step;
    }

    public void Finish(string idGame = "")
    {
        IdGame = idGame;
        CurrentStep = PrepareStep.None;
        IsLoadGame = true;
    }
}