using BoardGame.Game.Scenario;
using BoardGame.Models;

namespace BoardGame.Repository;

public interface IStartScenarioRepository
{
    public IStartScenario GetScenarioByType(ScenarioType scenarioType);
}