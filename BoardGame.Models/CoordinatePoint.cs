namespace BoardGame.Models;
public record CoordinatePoint(int IdPlayFieldTil, int IdNode)
{
    public override int GetHashCode()
    {
        return HashCode.Combine(IdPlayFieldTil, IdNode);
    }
    public override string ToString()
    {
        return $"Id:{IdPlayFieldTil}: Node:{IdNode}";
    }
}
