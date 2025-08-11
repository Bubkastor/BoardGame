 namespace BoardGame.Models.Mediator.Quieres;

public class GetMapQueryResult
{
    public string IdGame { get; set; }
    public IEnumerable<IEnumerable<Cell>>? Map { get; set; }
}
