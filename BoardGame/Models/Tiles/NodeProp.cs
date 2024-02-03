using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model.Tiles
{
    public class NodeProp
    {
        public int IdNode { get; set; }
        public MonsterType MonsterType { get; set; }
        public MeetType MeetType { get; set; }
        public DifficultyAreaType DifficultyAreaType { get; set; }
        public Meet Meet { get; set; }
        public List<double> NeighborsNode { get; set; }
    }
}
