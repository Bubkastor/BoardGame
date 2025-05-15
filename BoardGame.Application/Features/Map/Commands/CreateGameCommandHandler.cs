using BoardGame.Models;
using BoardGame.Models.Mediator.Commands;
using BoardGame.Repository;
using MediatR;

namespace BoardGame.Application.Features.Map.Commands
{
    internal class CreateGameCommandHandler(
        IGameStateRepository gameStateRepository,
        IStartScenarioRepository startScenarioRepository) : IRequestHandler<CreateGameCommand, CreateGameCommandResult>
    {
        public async Task<CreateGameCommandResult> Handle(CreateGameCommand request, CancellationToken cancellationToken)
        {
            var result = new CreateGameCommandResult();
            var id = 1;
            result.IdGame = id;
            var gameState = await gameStateRepository.GetGameStateAsync(id);
            if (gameState != null)
            {
                return result;
            }
            gameState = new GameState()
            {
                Scenario = ScenarioType.Commonwealth,
                Map = startScenarioRepository.GetScenarioByType(ScenarioType.Commonwealth).Map
            };

            gameStateRepository.CreateGameState(id, gameState);
            return result;
        }
    }
}
