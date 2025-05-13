using BoardGame.Game.Scenario;
using BoardGame.Models;

namespace BoardGame.Repository;

public class StartScenarioRepository : IStartScenarioRepository
{
    public IStartScenario GetScenarioByType(ScenarioType scenarioType)
    {
        return scenarioType switch
        {
            ScenarioType.Commonwealth => new StartScenario(),
            ScenarioType.CapitalWasteland => new StartScenario2(),
            ScenarioType.FarHarbor => new StartScenario3(),
            ScenarioType.Pit => new StartScenario4(),
            _ => throw new NotImplementedException()
        };
    }
}