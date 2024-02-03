using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model.Player
{
    public class HealPoint
    {
        public int MaxHP { get; init; }
        public int CurrentHp { get; set; }
    }
}
