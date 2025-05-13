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
    public IPlayFieldTilRepository _repo = new PlayFieldTilRepository();
    private ApiClient _apiClient;
    public IEnumerable<IEnumerable<Cell>>? _maps = null;

    public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _apiClient = new ApiClient("https://localhost:7032", httpClientFactory.CreateClient());        
    }

    public async Task OnGet()
    {
        var id = await _apiClient.GameAsync();
        var gameState = await _apiClient.GameAllAsync(id);
        _maps = gameState;
    }

    public string GetTilColor(TileType tileType)
    {
        if (tileType == TileType._2)
            return "green";
        if (tileType == TileType._3)
            return "red";
        if (tileType == TileType._1)
            return "start";
        return "";
    }

    public string GetImg(Cell cell)
    {
        if (cell.IdTil != 0)
        {
            return _repo.GetImgById(cell.IdTil);
        }

        if (cell.TileType != TileType._0)
        {
            if (cell.TileType == TileType._3)
            {
                return "Red.png";
            }

            if (cell.TileType == TileType._2)
            {
                return "Green.png";
            }
        }

        return "";
    }

    public async Task TurnCell(int row, int col)
    {
        await _apiClient.PlayerAsync(1, row, col);
    }
}