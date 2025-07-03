namespace BoardGame.Models.Repository;

public class GameStateRepository : IGameStateRepository
{
    private Dictionary<int, GameState> _gameStates = new Dictionary<int, GameState>();
    public void CreateGameState(int id, GameState gameState)
    {
        _gameStates.TryAdd(id, gameState);
    }

    public async Task<GameState?> GetGameStateAsync(int id)
    {
        if(_gameStates.TryGetValue(id, out var state))
        {
            return await Task.FromResult(state);
        }

        return null;
    }

    public void UpdateGameState(int id, GameState gameState)
    {
        _gameStates[id] = gameState;
    }
}