using BoardGame.Models.Tiles;

namespace BoardGame.Models;
public class Cell
{
    public int IdTil { get; set; }
    public TileType TileType { get; set; }
    public bool IsOpen { get; set; }
    public Cell(int idTil, TileType type = TileType.None)
    {
        IdTil = idTil;
        TileType = type;
    }
    public Cell(TileType type) 
    { 
        TileType = type;
    }
}
