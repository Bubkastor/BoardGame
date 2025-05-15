using BoardGame.Models.Map;

namespace BoardGame.Models.Mediator.Quieres
{
    public class GetMapQueryResult
    {
        public int IdGame { get; set; }
        public IEnumerable<IEnumerable<Cell>>? Map { get; set; }
    }
}
