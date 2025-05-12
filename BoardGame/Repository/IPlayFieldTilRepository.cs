using BoardGame.Model.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Repository
{
    public interface IPlayFieldTilRepository
    {
        public List<PlayFieldTil> GetPlayFieldTils();
        public PlayFieldTil GetPlayFieldTilById(int id);
        public List<PlayFieldTil> GetPlayFieldTilByTileType(TileType tileType);
        public string GetImgById(int id);
    }
}
