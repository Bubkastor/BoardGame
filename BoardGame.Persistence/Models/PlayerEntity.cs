using LinqToDB.Mapping;

namespace BoardGame.Persistence.Models;

[Table("Players")]

internal class PlayerEntity
{
    [Column, NotNull]
    public int Id { get; set; }
    [Column, NotNull]
    public int GameSessionId { get; set; }
    [Column, NotNull]
    public required string Name { get; set; }
}