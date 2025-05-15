using MediatR;

namespace BoardGame.Models.Mediator.Commands;

public class CreateGameCommand : IRequest<CreateGameCommandResult>
{
}
