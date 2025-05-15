using BoardGame.Repository;

namespace BoardGame.View.Pages;
public partial class Playfield
{
    public IPlayFieldTilRepository _repo = new PlayFieldTilRepository();
    private ApiClient _apiClient;
    public IEnumerable<IEnumerable<Cell>>? _maps = null;
    public bool IsLoad { get; private set; } = false;

    public Playfield(IHttpClientFactory httpClientFactory)
    {
        _apiClient = new ApiClient("https://localhost:7032", httpClientFactory.CreateClient());
    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            var response = await _apiClient.GameGETAsync();
            var gameState = await _apiClient.GamePOSTAsync(response.IdGame);
            if (gameState.Map != null)
            {
                _maps = gameState.Map;
                IsLoad = true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        await base.OnInitializedAsync();
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
        var response = await _apiClient.GameGETAsync();
        var gameState = await _apiClient.GamePOSTAsync(response.IdGame);
        if (gameState.Map != null)
            _maps = gameState.Map;
    }
}
