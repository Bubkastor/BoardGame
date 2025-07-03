using MediatR;

namespace BoardGame.Models.Mediator.Commands;

public class TurnCellCommand : IRequest<TurnCellCommandResult>
{
    public int IdGame { get; set; }
    public int Col { get; set; }
    public int Row { get; set; }
}
