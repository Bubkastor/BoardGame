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
    internal class StartScenario
    {
        // Содружество
        Cell[,] map =
        {
            { new Cell(14),  new Cell(TileType.Green), new Cell(TileType.Green), new Cell(TileType.Red), new Cell(TileType.Red) },
            { new Cell(0),  new Cell(TileType.Green), new Cell(TileType.Green), new Cell(20), new Cell(TileType.Red) },
            { new Cell(TileType.Green), new Cell(TileType.Green), new Cell(19), new Cell(TileType.Red),  new Cell(TileType.Red) },
            { new Cell(0), new Cell(TileType.Green), new Cell(TileType.Green), new Cell(TileType.Red),  new Cell(15) },
        };

    }
}
