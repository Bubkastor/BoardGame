namespace BoardGame.Models.Repository;

public interface IGameStateRepository
{
    public Task<int> CreateGameStateAsync(GameState gameState);
    public Task<GameState?> GetGameStateAsync(int id);
    public void UpdateGameState(int id, GameState gameState);
}