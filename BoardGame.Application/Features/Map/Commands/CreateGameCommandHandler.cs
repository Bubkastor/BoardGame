using BoardGame.Models;
using BoardGame.Models.Enemy;
using BoardGame.Models.Mediator.Commands;
using BoardGame.Models.Repository;
using MediatR;

namespace BoardGame.Application.Features.Map.Commands;

internal class CreateGameCommandHandler(
    IGameStateRepository gameStateRepository,
    IStartScenarioRepository startScenarioRepository) : IRequestHandler<CreateGameCommand, CreateGameCommandResult>
{
    public async Task<CreateGameCommandResult> Handle(CreateGameCommand request, CancellationToken cancellationToken)
    {
        var result = new CreateGameCommandResult();
        var gameState = new GameState()
        {
            Scenario = request.scenarioType,
            Map = startScenarioRepository.GetScenarioByType(request.scenarioType).Map,
            PlayerNames = new List<string>(),
            NpsInfos = new List<Npc>(),
            PlayersInfo = new Dictionary<int, Models.PlayerState.Player>()
        };

        var idGame = await gameStateRepository.CreateGameStateAsync(gameState);
        result.IdGame = idGame;

        return result;
    }
}
