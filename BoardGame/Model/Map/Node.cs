using BoardGame.Model.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model.Map
{
    public class Node
    {
        public CoordinatePoint Coordinate { get; set; }
        public List<Node> Neighbors { get; set; }
        public List<int> Side { get; set; }
        public DifficultyAreaType DifficultyAreaType { get; set; }
    }
}
