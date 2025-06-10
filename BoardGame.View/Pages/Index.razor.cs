using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages;

public partial class Index
{
    public PrepareStep CurrentStep { get; private set; } = PrepareStep.None;
        
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

    public void Finish()
    {
        
    }
}