using BoardGame.Persistence.Models;
using LinqToDB;
using LinqToDB.Data;

namespace BoardGame.Persistence;

internal class BoardGameDbStorage(BoardGameDbOptions options) : DataConnection(options.DataOptions)
{
    public ITable<GameSessionEntity> GameSessions => this.GetTable<GameSessionEntity>();
    public ITable<MapEntity> Maps => this.GetTable<MapEntity>();
    public ITable<PlayerEntity> Players => this.GetTable<PlayerEntity>();
}
