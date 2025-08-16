using BoardGame.Models;
using BoardGame.Models.Repository;
using BoardGame.Models.Tiles;
using BoardGame.View.Config;
using BoardGame.View.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace BoardGame.View.Pages;
public partial class Playfield(IHttpClientFactory httpClientFactory)
{
    [Inject]
    public IOptionsMonitor<SettingsApi> SettingsApi { get; set; } 
    [Parameter]
    public string IdGame { get; set; }
    [Parameter]
    public ScenarioType ScenarioType { get; set; }
    [Parameter]
    public int PlayersCount { get; set; }
    
    public IPlayFieldTilRepository _repo = new PlayFieldTilRepository();
    private ApiClient _apiClient;
    public IEnumerable<IEnumerable<Cell>>? _maps = null;
    public bool IsLoad { get; private set; } = false;
    [Inject]
    protected BrowserStorageService Storage { get; init; }
    private static string ID_GAME_KEY = "ID_GAME_KEY";


    protected override async Task OnInitializedAsync()
    {
        try
        {
            Console.WriteLine("=========");
            Console.WriteLine(SettingsApi.CurrentValue.ConnectionString);
            Console.WriteLine("=========");
            _apiClient =  new(SettingsApi.CurrentValue.ConnectionString, httpClientFactory.CreateClient());
            var gameExist = false;
            if (!string.IsNullOrWhiteSpace(IdGame))
            {
                var checkGameResponse = await _apiClient.StatusAsync(IdGame);
                gameExist = checkGameResponse.GameExist;
            }

            if (!gameExist)
            {
                var startResult = await _apiClient.StartAsync(ScenarioType, PlayersCount);
                IdGame = startResult.IdGame.ToString();
                await Storage.SetItem(ID_GAME_KEY, IdGame);
            }
            var gameState = await _apiClient.MapAsync(IdGame);
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

    public async Task TurnCell(int row, int col)
    {
        await _apiClient.PlayerAsync(1, row, col);
        
        var gameState = await _apiClient.MapAsync(IdGame);
        if (gameState.Map != null)
            _maps = gameState.Map;
    }
}
