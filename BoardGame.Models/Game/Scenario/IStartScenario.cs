using BoardGame.Models;

namespace BoardGame.Models.Game.Scenario;

public interface IStartScenario
{
    public List<List<Cell>> Map { get; }
    public string Name { get; }
}