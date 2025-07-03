namespace BoardGame.Models.Enemy;

public record Npc
{
    public CoordinatePoint Position { get; set; }
    public string Name { get; set; }
    public int Lvl { get; set; }
    public NpcType EnemyType { get; set; }

    //<summary>
    // Уязвимость
    //</summary>
    public Vulnerability Vulnerability { get; init; }

    //<summary>
    // Свойства
    //</summary>
    public NpcProperties Properties { get; init; }

    //<summary>
    // Активная ли карта
    //</summary>
    public bool IsActive { get; set; }
}

