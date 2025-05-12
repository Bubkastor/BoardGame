using BoardGame.Models.Map;

namespace BoardGame.Game.Scenario;

public interface IStartScenario
{
    public List<List<Cell>> Map { get; }
    public string Name { get; }
}