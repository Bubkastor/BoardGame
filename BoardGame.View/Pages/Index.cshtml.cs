using BoardGame.Game.Scenario;
using BoardGame.Model.Tiles;
using BoardGame.Models.Map;
using BoardGame.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BoardGame.View.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public IStartScenario _startScenario = new StartScenario();
    public IPlayFieldTilRepository _repo = new PlayFieldTilRepository();

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }

    public string GetTilColor(TileType tileType)
    {
        if (tileType == TileType.Green)
            return "green";
        if (tileType == TileType.Red)
            return "red";
        if (tileType == TileType.Start)
            return "start";
        return "";
    }

    public string GetImg(Cell cell)
    {
        if (cell.IdTil != 0)
        {
            return _repo.GetImgById(cell.IdTil);
        }

        if (cell.TileType != TileType.None)
        {
            if (cell.TileType == TileType.Red)
            {
                return "Red.png";
            }

            if (cell.TileType == TileType.Green)
            {
                return "Green.png";
            }
        }

        return "";
    }
}