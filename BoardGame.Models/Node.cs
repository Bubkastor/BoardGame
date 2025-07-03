namespace BoardGame.Models;
public class Node
{
    public CoordinatePoint Coordinate { get; set; }
    public List<Node> Neighbors { get; set; }
    public List<double> Side { get; set; }
    public DifficultyAreaType DifficultyAreaType { get; set; }
}
