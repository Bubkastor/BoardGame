using BoardGame.Models.Tiles;

namespace BoardGame.Models.Game.Scenario;

public class StartScenario4 : IStartScenario
{
    public StartScenario4()
    {
        
    }

    public List<List<Cell>> Map => _map;
    public string Name => "Пит";

    private List<List<Cell>> _map = new List<List<Cell>>()
    {
        new List<Cell>(){ new Cell(0),  new Cell(0), new Cell(26)},
        new List<Cell>(){ new Cell(0), new Cell(23), new Cell(24)},
        new List<Cell>(){ new Cell(0), new Cell(TileType.Red), new Cell(TileType.Red), new Cell(TileType.Red) },
        new List<Cell>(){ new Cell(TileType.Green), new Cell(TileType.Red), new Cell(TileType.Red), new Cell(TileType.Red) },
        new List<Cell>(){ new Cell(TileType.Green), new Cell(TileType.Green),new Cell(TileType.Green), new Cell(TileType.Green) },
        new List<Cell>(){ new Cell(TileType.Green), new Cell(TileType.Green),new Cell(TileType.Green), new Cell(14, TileType.Start) },
    };
    
}
