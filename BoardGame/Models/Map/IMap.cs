using BoardGame.Model.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Models.Map
{
    public interface IMap
    {
        Node Node { get; set; }
        Dictionary<CoordinatePoint, Node> NodeList { get; set; }
    }
}
