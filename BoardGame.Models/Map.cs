
using BoardGame.Models.Builder;

namespace BoardGame.Models;

public class Map : IMap
{      
    private Node _map;
    private Dictionary<CoordinatePoint, Node> _allNode;
    private IBuildNodeGraph _buildNodeGraph;
    public Map()
    {
        _map = new Node();
        _allNode = new Dictionary<CoordinatePoint, Node>();
        _buildNodeGraph = new BuildNodeGraph();
    }

    public Map(Node map, Dictionary<CoordinatePoint, Node> nodeList)
    {
        _map = map;
        _allNode = nodeList;
        _buildNodeGraph = new BuildNodeGraph();
    }

    Node IMap.Node { get => _map; set => throw new NotImplementedException(); }
    Dictionary<CoordinatePoint, Node> IMap.NodeList { get => _allNode; set => throw new NotImplementedException(); }

}
