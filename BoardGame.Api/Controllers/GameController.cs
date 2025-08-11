using BoardGame.Models;
using BoardGame.Models.Mediator.Commands;
using BoardGame.Models.Mediator.Quieres;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BoardGame.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameController(IMediator mediator) : Controller
{
    [HttpGet]
    public async Task<CreateGameCommandResult> StartGameAsync(ScenarioType scenarioType, int playersCount)
    {
        var command = new CreateGameCommand()
        {
            scenarioType = scenarioType,
            PlayersCount = playersCount
        };
        return await mediator.Send(command);
    }

    [HttpGet]
    public async Task<CheckGameQueryResult> CheckGameAsync(string idGame)
    {
        var query = new CheckGameQuery()
        {
            IdGame = idGame
        };
        return await mediator.Send(query);
    }
    

    [HttpPost]
    public async Task<GetMapQueryResult> GetMap(int idGame)
    {
        var query = new GetMapQuery()
        {
            IdGame = idGame
        };

        return await mediator.Send(query);
    }
}