using BoardGame.Game.Scenario;
using BoardGame.Model.Tiles;
using BoardGame.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BoardGame.View.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public StartScenario _startScenario = new StartScenario();
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
}
