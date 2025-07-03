using LinqToDB.Mapping;

namespace BoardGame.Persistence.Models;

[Table("Maps")]
internal class MapEntity
{
    [Column, NotNull]
    public int Id { get; set; }
    [Column, NotNull]
    public int GameSessionId { get; set; }
    [Column, NotNull]
    public int ScenarioType { get; set; }
}