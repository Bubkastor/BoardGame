namespace BoardGame.Models.View;

public record ScenarioTypeName(ScenarioType scenario, string nameScenario)
{
     public string Id
     {
          get => NameScenario;
     }
     public ScenarioType Scenario { get; init; } = scenario;
     public string NameScenario { get; init; } = nameScenario;
     public override string ToString()
     {
          return NameScenario;
     }
}