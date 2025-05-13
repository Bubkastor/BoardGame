using BoardGame.Model.Map;
using BoardGame.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BoardGame.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerController(
    IGameStateRepository gameStateRepository,
    IPlayFieldTilRepository playFieldTilRepository
) : Controller
{
    [HttpPost]
    public void TurnCell(int idGame, int row, int col)
    {
        var gameState = gameStateRepository.GetGameState(idGame);
        if (gameState == null)
        {
            throw new ArgumentNullException();
        }

        var cell = gameState.Map[row][col];
        var existTilsType = gameState.Map
            .SelectMany(r => r)
            .Where(c => c.TileType == cell.TileType)
            .Select(x => x.IdTil)
            .Distinct()
            .ToList();

        var tillsByType = playFieldTilRepository.GetPlayFieldTilByTileType(cell.TileType);
        tillsByType.RemoveAll(x => existTilsType.Contains(x.Id));
        var random = new Random();
        var newTil = tillsByType[random.Next(0, tillsByType.Count+1)];
        
        gameState.Map[row][col].IdTil = newTil.Id;
        gameStateRepository.UpdateGameState(idGame, gameState);
    }
}