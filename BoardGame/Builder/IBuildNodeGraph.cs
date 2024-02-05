using BoardGame.Model.Map;
using BoardGame.Model.Tiles;
using BoardGame.Models.Map;

namespace BoardGame.Builder
{
    public interface IBuildNodeGraph
    {
        public IMap Create(PlayFieldTil playFieldTils);
        public void AddRight(IMap left, int idPlayFieldTil, PlayFieldTil playFieldTils);
        public void AddLeft(IMap right, int idPlayFieldTil, PlayFieldTil playFieldTils);
        public void AddTopRight(IMap topRight, int rootNodeId, PlayFieldTil playFieldTils);
        public void AddTopLeft(IMap topLeft, int rootNodeId, PlayFieldTil playFieldTils);
        public void AddBottomRight(IMap bottomRight, int rootNodeId, PlayFieldTil playFieldTils);
        public void AddBottomLeft(IMap bottomLeft, int rootNodeId, PlayFieldTil playFieldTils);

    }
}
