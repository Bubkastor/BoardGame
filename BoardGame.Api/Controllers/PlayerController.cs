using BoardGame.Models.Mediator.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BoardGame.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerController(IMediator mediator) : Controller
{
    [HttpPost]
    public async Task<TurnCellCommandResult> TurnCell(int idGame, int row, int col)
    {
        var command = new TurnCellCommand
        {
            IdGame = idGame,
            Col = col,
            Row = row
        };
        return await mediator.Send(command);
    }
}