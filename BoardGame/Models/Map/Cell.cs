using BoardGame.Model.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Models.Map
{
    public class Cell
    {
        public int IdTil { get; set; }
        public TileType TileType { get; set; }
        public Cell(int idTil, TileType type = TileType.None)
        {
            IdTil = idTil;
            TileType = type;
        }
        public Cell(TileType type) 
        { 
            TileType = type;
        }
    }
}
