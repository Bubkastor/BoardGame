using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model.Map
{
    public record CoordinatePoint(int IdPlayFieldTil, int IdNode)
    {
        public override int GetHashCode()
        {
            return HashCode.Combine(IdPlayFieldTil, IdNode);
        }
        public override string ToString()
        {
            return $"Id:{IdPlayFieldTil}: Node:{IdNode}";
        }
    }
}
