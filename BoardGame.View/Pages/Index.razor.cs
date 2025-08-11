using BoardGame.Models;
using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages;

public partial class Index
{
    public PrepareStep CurrentStep { get; private set; } = PrepareStep.None;
    public int PlayersCount { get; private set; }
    public ScenarioType ScenarioType { get; private set; }
    public string IdGame = string.Empty;
    public bool IsLoadGame = false;
    

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

    public void SetPlayersCount(int value)
    {
        PlayersCount = value;
    }
    public void SetScenarioType(ScenarioType scenarioType)
    {
        ScenarioType = scenarioType;
    }
}