using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model.Enemy
{
    [Flags]
    public enum Body
    {
        Head = 1,
        Body = 2,
        Armors = 4,
        Legs = 8
    }
}
