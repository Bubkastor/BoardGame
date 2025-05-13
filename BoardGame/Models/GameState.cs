using BoardGame.Model;
using BoardGame.Model.Enemy;
using BoardGame.Models.Map;

namespace BoardGame.Models;

public class GameState
{
    public ScenarioType Scenario { get; set; } = ScenarioType.Commonwealth;
    public List<List<Cell>> Map { get; set; } = new List<List<Cell>>();
    public List<string>? PlayerNames { get; set; }
    public Dictionary<int, Player>? PlayersInfo { get; set; }
    public List<Npc>? NpsInfos { get; set; }
}