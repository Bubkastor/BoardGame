using BoardGame.Models;
using BoardGame.Models.View;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BoardGame.View.Pages.PrepareGame;

public partial class SelectScenario: ComponentBase
{
    private Scenarios Scenarios { get; } = new();
    private ScenarioTypeName CurrentScenarioType { get; set; }
    private string _selectedScenarioId;
    private string SelectedScenarioId {
        get => _selectedScenarioId;
        set
        {
            _selectedScenarioId = value;
            ChangeEventArgs selectedEventArgs = new ChangeEventArgs();
            selectedEventArgs.Value = value;
            OnChangeSelected(selectedEventArgs);
        } 
    }
    [Parameter]
    public required EventCallback SetStep { get; set; }
    [Parameter]
    public required EventCallback<ScenarioType> SetScenario { get; set; }    

    public SelectScenario()
    {
        CurrentScenarioType = Scenarios.ScenariosList.First();
        SelectedScenarioId = CurrentScenarioType.Id;
    }

    protected async Task NextScreen()
    {
        await SetScenario.InvokeAsync(CurrentScenarioType.Scenario);
        await SetStep.InvokeAsync();
    }
    
    private async Task OnChangeSelected(ChangeEventArgs e)
    {
        var selectedId = e.Value.ToString(); // Получаем Id выбранного сценария
        CurrentScenarioType = Scenarios.ScenariosList.First(s => s.Id == selectedId);
        Console.WriteLine($"Выбран сценарий: {CurrentScenarioType.NameScenario}");
        //CurrentScenarioType = scenarioType;
        await SetScenario.InvokeAsync(CurrentScenarioType.Scenario);
    }
}