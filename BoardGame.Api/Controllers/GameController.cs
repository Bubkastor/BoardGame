using BoardGame.Models;
using BoardGame.Models.Mediator.Commands;
using BoardGame.Models.Mediator.Quieres;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BoardGame.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameController(IMediator mediator) : Controller
{
    [HttpPost("start")]
    [ProducesResponseType(typeof(CreateGameCommandResult), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<CreateGameCommandResult> StartGame([FromQuery] ScenarioType scenarioType, [FromQuery, Range(1, 4)] int playersCount)
    {
        var command = new CreateGameCommand()
        {
            scenarioType = scenarioType,
            PlayersCount = playersCount
        };
        return await mediator.Send(command);
    }

    [HttpGet("{idGame}/status")]
    [ProducesResponseType(typeof(CheckGameQueryResult), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<CheckGameQueryResult> CheckGame([FromRoute] string idGame)
    {
        var query = new CheckGameQuery()
        {
            IdGame = idGame
        };
        return await mediator.Send(query);
    }


    [HttpGet("{idGame}/map")]
    [ProducesResponseType(typeof(GetMapQueryResult), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<GetMapQueryResult> GetMap([FromRoute]string idGame)
    {
        var query = new GetMapQuery()
        {
            IdGame = idGame
        };

        return await mediator.Send(query);
    }
}