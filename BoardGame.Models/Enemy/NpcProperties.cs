namespace BoardGame.Models.Enemy;
/// <summary>
/// Свойства врагов
/// </summary>
[Flags]
public enum NpcProperties
{
    None = 0,
    /// <summary>
    /// Агресивный
    /// </summary>
    Aggressive = 1,

    /// <summary>
    /// Юроня
    /// </summary>
    Armor = 2,

    /// <summary>
    /// Добыча
    /// </summary>
    Booty = 4,

    /// <summary>
    /// Радиактивный
    /// </summary>
    Radioactive = 8,

    /// <summary>
    /// Дальнобольнный
    /// </summary>
    LongRange = 16,

    /// <summary>
    /// Бегство
    /// </summary>
    Escape = 32
}

