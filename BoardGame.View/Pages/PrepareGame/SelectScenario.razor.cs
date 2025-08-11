using BoardGame.Models;
using BoardGame.Models.View;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BoardGame.View.Pages.PrepareGame;

public partial class SelectScenario: ComponentBase
{
    public Scenarios Scenarios { get; set; }
    public ScenarioTypeName CurrentScenarioType { get; set; }
    public string SelectedScenarioId { get; set; }
    [Parameter]
    public required EventCallback SetStep { get; set; }
    [Parameter]
    public required EventCallback<ScenarioType> SetScenario { get; set; }    

    public SelectScenario()
    {
        Scenarios = new Scenarios();
        CurrentScenarioType = Scenarios.ScenariosList.First();
    }

    protected async Task NextScreen()
    {
        await SetStep.InvokeAsync();
    }
    

    private async Task SelectOption(ScenarioTypeName scenarioType)
    {
        CurrentScenarioType = scenarioType;
        await SetScenario.InvokeAsync(scenarioType.Scenario);
    }

    private async Task OnScenarioChanged(ChangeEventArgs e)
    {
        var selectedId = e.Value.ToString(); // Получаем Id выбранного сценария
        CurrentScenarioType = Scenarios.ScenariosList.First(s => s.Id == selectedId);
        Console.WriteLine($"Выбран сценарий: {CurrentScenarioType.NameScenario}");
        //CurrentScenarioType = scenarioType;
        await SetScenario.InvokeAsync(CurrentScenarioType.Scenario);
    }
}