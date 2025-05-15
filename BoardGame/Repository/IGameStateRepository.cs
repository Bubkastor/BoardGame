using BoardGame.Models;

namespace BoardGame.Repository;

public interface IGameStateRepository
{
    public void CreateGameState(int id, GameState gameState);
    public Task<GameState?> GetGameStateAsync(int id);
    public void UpdateGameState(int id, GameState gameState);
}