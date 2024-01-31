using BoardGame.Model.Map;
using BoardGame.Model.Tiles;

namespace BoardGame.Builder
{
    public interface IBuildNodeGraph
    {
        public (Node, Dictionary<CoordinatePoint, Node>) Create(PlayFieldTil playFieldTils);
        public void AddRight((Node, Dictionary<CoordinatePoint, Node>) left, PlayFieldTil playFieldTils);
        public void AddLeft((Node, Dictionary<CoordinatePoint, Node>) right, PlayFieldTil playFieldTils);
        public void AddTopRight((Node, Dictionary<CoordinatePoint, Node>) topRight, int rootNodeId, PlayFieldTil playFieldTils);
        public void AddTopLeft((Node, Dictionary<CoordinatePoint, Node>) topLeft, int rootNodeId, PlayFieldTil playFieldTils);
        public void AddBottomRight((Node, Dictionary<CoordinatePoint, Node>) bottomRight, int rootNodeId, PlayFieldTil playFieldTils);
        public void AddBottomLeft((Node, Dictionary<CoordinatePoint, Node>) bottomLeft, int rootNodeId, PlayFieldTil playFieldTils);

    }
}
