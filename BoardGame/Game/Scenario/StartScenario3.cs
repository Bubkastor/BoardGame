using BoardGame.Model.Map;
using BoardGame.Model.Tiles;
using BoardGame.Models.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Game.Scenario
{
    public class StartScenario3 : IStartScenario
    {
        public StartScenario3()
        {
            
        }

        public List<List<Cell>> Map => _map;
        public string Name => "Фар-Харбор";

        // Содружество
        private List<List<Cell>> _map = new List<List<Cell>>()
        {
            new List<Cell>(){ new Cell(14, TileType.Start),  new Cell(TileType.Green), new Cell(TileType.Green)},
            new List<Cell>(){ new Cell(TileType.Green), new Cell(TileType.Green), new Cell(TileType.Green), new Cell(27) },
            new List<Cell>(){ new Cell(0), new Cell(0), new Cell(TileType.Green), new Cell(TileType.Green),  new Cell(TileType.Green) },
            new List<Cell>(){ new Cell(22), new Cell(TileType.Red), new Cell(25),  new Cell(TileType.Red) },
            new List<Cell>(){ new Cell(TileType.Red), new Cell(TileType.Red), new Cell(TileType.Red),  new Cell(TileType.Red) },
        };
    }
}
