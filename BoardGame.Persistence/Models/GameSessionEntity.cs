using LinqToDB.Mapping;

namespace BoardGame.Persistence.Models;

[Table("GameSessions")]
internal class GameSessionEntity
{
    [Column, NotNull]
    public int Id { get; set; }
    
    [Column, NotNull]
    public required string Code { get; set; }
    [Column, NotNull]
    public required DateTime CreateTimeUtc { get; set; }
}