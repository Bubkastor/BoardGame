using BoardGame.Models;
using BoardGame.Models.Map;
using BoardGame.Models.Mediator.Commands;
using BoardGame.Models.Mediator.Quieres;
using BoardGame.Repository;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BoardGame.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameController(IMediator mediator) : Controller
{
    [HttpGet]
    public async Task<CreateGameCommandResult> StartGame()
    {
        var command = new CreateGameCommand();
        return await mediator.Send(command);
    }

    [HttpPost]
    public async Task<GetMapQueryResult> GetMap(int id)
    {
        var query = new GetMapQuery()
        {
            IdGame = id
        };

        return await mediator.Send(query);
    }
}