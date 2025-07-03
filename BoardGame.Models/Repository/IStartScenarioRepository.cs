using BoardGame.Models.Game.Scenario;

namespace BoardGame.Models.Repository;

public interface IStartScenarioRepository
{
    public IStartScenario GetScenarioByType(ScenarioType scenarioType);
}