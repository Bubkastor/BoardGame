using BoardGame.Model.Map;
using BoardGame.Model.Tiles;

namespace BoardGame.Builder
{
    public interface IBuildNodeGraph
    {
        public (Node, Dictionary<CoordinatePoint, Node>) Create(PlayFieldTil playFieldTils);
        public void AddRight((Node, Dictionary<CoordinatePoint, Node>) left, PlayFieldTil playFieldTils);
    }
}
