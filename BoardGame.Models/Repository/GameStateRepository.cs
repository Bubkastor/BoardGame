namespace BoardGame.Models.Repository;

public class GameStateRepository : IGameStateRepository
{
    private List<GameState> _gameStates = new List<GameState>();
    public async Task<int> CreateGameStateAsync(GameState gameState)
    {
        if (!_gameStates.Contains(gameState))
        {
            _gameStates.Add(gameState);
        }
        return await Task.FromResult(_gameStates.IndexOf(gameState));
    }

    public async Task<GameState?> GetGameStateAsync(int id)
    {
        if (id >= 0 && id < _gameStates.Count)
        {
            var state = _gameStates[id];
            return await Task.FromResult(state);
        }

        return null;
    }

    public void UpdateGameState(int id, GameState gameState)
    {
        _gameStates[id] = gameState;
    }
}