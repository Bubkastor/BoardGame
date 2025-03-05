using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model
{
    [Flags]
    public enum SPECIALType
    {
        S = 1,
        P = 2,
        E = 4,
        C = 8,
        I = 16,
        A = 32,
        L = 64,
    }
}
