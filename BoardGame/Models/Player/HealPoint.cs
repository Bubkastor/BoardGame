using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model
{
    public record HealPoint
    {
        public HealPoint()
        {
            MaxHP = 16;
            CurrentHp = 16;
        }

        public int MaxHP { get; init; }
        public int CurrentHp { get; set; }
    }
}
