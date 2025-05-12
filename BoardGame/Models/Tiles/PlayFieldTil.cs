namespace BoardGame.Model.Tiles
{
    public class PlayFieldTil
    {
        public int Id { get; set; }
        public TileType Type { get; set; }
        public List<NodeProp> NodeProps { get; set; }
        public bool Visible { get; set; }
        public string Img { get; init; }
    }
}
