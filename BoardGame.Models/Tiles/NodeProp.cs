namespace BoardGame.Models.Tiles;

public class NodeProp
{
    public int IdNode { get; set; }
    public NpcType NpcType { get; set; } = NpcType.None;
    public MeetType MeetType { get; set; } = MeetType.None;
    public DifficultyAreaType DifficultyAreaType { get; set; } = DifficultyAreaType.None;
    public Meet Meet { get; set; }
    public List<double> NeighborsNode { get; set; }
}
