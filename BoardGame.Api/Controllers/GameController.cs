using BoardGame.Models;
using BoardGame.Models.Map;
using BoardGame.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BoardGame.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameController(
    IGameStateRepository gameStateRepository, 
    IStartScenarioRepository startScenarioRepository) : Controller
{
    [HttpGet]
    public int StartGame()
    {
        var id = 1;
        var gameState = gameStateRepository.GetGameState(id);
        if (gameState != null)
        {
            return id;
        }
        gameState = new GameState()
        {
            Scenario = ScenarioType.Commonwealth,
            Map = startScenarioRepository.GetScenarioByType(ScenarioType.Commonwealth).Map
        };
        gameStateRepository.CreateGameState(id, gameState);
        return id;
    }

    [HttpPost]
    public List<List<Cell>> GetMap(int id)
    {
        var state = gameStateRepository.GetGameState(id);
        if (state != null)
        {
            return state.Map;
        }
        else
        {
            return new List<List<Cell>>();
        }
    }
}