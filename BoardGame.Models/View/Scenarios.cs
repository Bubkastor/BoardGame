namespace BoardGame.Models.View;

public class Scenarios
{
    public List<ScenarioTypeName> ScenariosList { get; init; } =
    [
        new ScenarioTypeName(ScenarioType.Commonwealth, "Содружество"),
        new ScenarioTypeName(ScenarioType.CapitalWasteland, "Столичная пустошь"),
        new ScenarioTypeName(ScenarioType.FarHarbor, "Фар-Харбор"),
        new ScenarioTypeName(ScenarioType.Pit, "Пит")
    ];
}