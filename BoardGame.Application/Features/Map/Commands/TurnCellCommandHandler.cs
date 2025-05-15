using BoardGame.Model.Tiles;
using BoardGame.Models;
using BoardGame.Models.Mediator.Commands;
using BoardGame.Repository;
using MediatR;

namespace BoardGame.Application.Features.Map.Commands
{
    internal class TurnCellCommandHandler(
        IGameStateRepository gameStateRepository,
        IPlayFieldTilRepository playFieldTilRepository) : IRequestHandler<TurnCellCommand, TurnCellCommandResult>
    {
        public async Task<TurnCellCommandResult> Handle(TurnCellCommand request, CancellationToken cancellationToken)
        {
            var gameState = await gameStateRepository.GetGameStateAsync(request.IdGame)
                ?? throw new ArgumentNullException(nameof(request.IdGame), "Game state not found");

            var cell = gameState.Map[request.Row][request.Col];

            var existTilsType = GetExistingTileIdsOfSameType(gameState, cell.TileType);
            var availableTiles = playFieldTilRepository.GetPlayFieldTilByTileType(cell.TileType)
                .Where(t => !existTilsType.Contains(t.Id))
                .ToList();

            if (availableTiles.Count == 0)
            {
                return new TurnCellCommandResult { IsTurn = false };
            }

            var newTile = GetRandomTile(availableTiles);
            UpdateGameState(request, gameState, newTile);

            return new TurnCellCommandResult { IsTurn = true };
        }

        private static List<int> GetExistingTileIdsOfSameType(GameState gameState, TileType tileType)
        {
            return gameState.Map
                .SelectMany(row => row)
                .Where(cell => cell.TileType == tileType)
                .Select(cell => cell.IdTil)
                .Distinct()
                .ToList();
        }

        private static PlayFieldTil GetRandomTile(List<PlayFieldTil> tiles)
        {
            var random = new Random();
            return tiles[random.Next(tiles.Count)];
        }

        private void UpdateGameState(TurnCellCommand request, GameState gameState, PlayFieldTil newTile)
        {
            gameState.Map[request.Row][request.Col].IdTil = newTile.Id;
            gameStateRepository.UpdateGameState(request.IdGame, gameState);
        }
    }
}
