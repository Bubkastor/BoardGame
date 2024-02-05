using BoardGame.Model.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Models
{
    public record DiceSide
    {
        public Vulnerability Vulnerability { get; set; }
        public int Hit { get; set; }
    }
}
