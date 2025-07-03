using BoardGame.Models.Game;

namespace BoardGame.Persistence.Repositories;

public interface IGameSessionRepository
{
    Task<GameSession> GetGameSessionByCodeAsync(string code);
    Task<GameSession> CreateGameSessionAsync();
}