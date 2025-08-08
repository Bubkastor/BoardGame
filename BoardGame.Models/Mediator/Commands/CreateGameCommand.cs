using MediatR;

namespace BoardGame.Models.Mediator.Commands;

public class CreateGameCommand : IRequest<CreateGameCommandResult>
{
    public ScenarioType scenarioType { get; set; }
    public int PlayersCount { get; set; }
}
