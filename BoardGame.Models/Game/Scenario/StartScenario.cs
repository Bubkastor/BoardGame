using BoardGame.Models.Tiles;

namespace BoardGame.Models.Game.Scenario;
public class StartScenario : IStartScenario
{
    public StartScenario()
    {
        
    }

    public List<List<Cell>> Map => _map;
    public string Name => "Содружество";

    // Содружество
    private List<List<Cell>> _map = new List<List<Cell>>()
    {
        new List<Cell>(){ new Cell(14, TileType.Start),  new Cell(TileType.Green), new Cell(TileType.Green), new Cell(TileType.Red), new Cell(TileType.Red) },
        new List<Cell>(){ new Cell(TileType.Green), new Cell(TileType.Green), new Cell(20), new Cell(TileType.Red) },
        new List<Cell>(){ new Cell(TileType.Green), new Cell(TileType.Green), new Cell(19), new Cell(TileType.Red),  new Cell(TileType.Red) },
        new List<Cell>(){ new Cell(TileType.Green), new Cell(TileType.Green), new Cell(TileType.Red),  new Cell(15) },
    };
    
    // Столичная пустошь
    public List<List<Cell>> Map2 = new List<List<Cell>>()
    {
        new List<Cell>(){new Cell(14, TileType.Start), new Cell(TileType.Green), new Cell(TileType.Green), new Cell(TileType.Green) },
        new List<Cell>(){new Cell(TileType.Green),new Cell(TileType.Green),new Cell(TileType.Green)},
        new List<Cell>(){new Cell(0), new Cell(TileType.Green),new Cell(18),new Cell(TileType.Red)},
        new List<Cell>(){new Cell(TileType.Green),new Cell(TileType.Red), new Cell(TileType.Red),new Cell(16)},
        new List<Cell>(){new Cell(12), new Cell(TileType.Red), new Cell(TileType.Red), new Cell(21)}
    };
}
