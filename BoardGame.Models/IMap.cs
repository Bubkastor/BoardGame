
namespace BoardGame.Models;

public interface IMap
{
    Node Node { get; set; }
    Dictionary<CoordinatePoint, Node> NodeList { get; set; }
}
