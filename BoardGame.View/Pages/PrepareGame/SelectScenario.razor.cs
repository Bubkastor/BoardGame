using BoardGame.Models;
using Microsoft.AspNetCore.Components;

namespace BoardGame.View.Pages.PrepareGame;

public partial class SelectScenario: ComponentBase
{
    public Scenarios Scenarios { get; set; }
    public ScenarioTypeName CurrentScenarioType { get; set; }
    public string SelectedScenarioId { get; set; }
    [Parameter]
    public required EventCallback SetStep { get; set; }

    public SelectScenario()
    {
        Scenarios = new Scenarios();
        CurrentScenarioType = Scenarios.ScenariosList.First();
    }

    protected async Task NextScreen()
    {
        await SetStep.InvokeAsync();
    }
    

    private void SelectOption(ScenarioTypeName scenarioType)
    {
        CurrentScenarioType = scenarioType;
    }
    private void OnScenarioChanged(ChangeEventArgs e)
    {
        var selectedId = e.Value.ToString(); // Получаем Id выбранного сценария
        CurrentScenarioType = Scenarios.ScenariosList.First(s => s.Id == selectedId);
        Console.WriteLine($"Выбран сценарий: {CurrentScenarioType.NameScenario}");
    }
}