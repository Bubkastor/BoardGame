using BoardGame.Model.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Models.Map
{
    internal class Cell
    {
        public int IdTil { get; set; }
        public TileType TileType { get; set; }
        public Cell(int idTil)
        {
            IdTil = idTil;
        }
        public Cell(TileType type) 
        { 
            TileType = type;
        }
    }
}
