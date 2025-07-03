using AutoMapper;
using BoardGame.Models.Game;
using LinqToDB;

namespace BoardGame.Persistence.Repositories;

internal class GameSessionRepository(BoardGameDbStorage storage, IMapper mapper) : IGameSessionRepository
{
    public async Task<GameSession> GetGameSessionByCodeAsync(string code)
    {
        var gameSessionEntity = await storage.GameSessions.FirstOrDefaultAsync(x => x.Code == code);
        if (gameSessionEntity == null) return null;
        var gameSession = mapper.Map<GameSession>(gameSessionEntity);
        return gameSession;
    }

    public Task<GameSession> CreateGameSessionAsync()
    {
        throw new NotImplementedException();
    }
}