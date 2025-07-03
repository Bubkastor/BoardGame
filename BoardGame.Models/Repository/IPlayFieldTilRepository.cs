using BoardGame.Models.Tiles;

namespace BoardGame.Models.Repository;

public interface IPlayFieldTilRepository
{
    public List<PlayFieldTil> GetPlayFieldTils();
    public PlayFieldTil GetPlayFieldTilById(int id);
    public List<PlayFieldTil> GetPlayFieldTilByTileType(TileType tileType);
    public string GetImgById(int id);
}
