using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model.Player
{
    public class SPECIAL
    {
        private SPECIALType _currentSpecial;
        public bool HasSPECIAL(SPECIALType type)
        {
            return _currentSpecial.HasFlag(type);
        }
    }
}
