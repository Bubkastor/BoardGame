using System.ComponentModel.DataAnnotations;

namespace BoardGame.Persistence.Migrations;

/// <summary>
/// Настройки BoardGameDb хранилища.
/// </summary>
public class BoardGameDbStorageSettings
{
    /// <summary>
    /// Строка настроек подключения к базе данных (required).
    /// </summary>
    [Required]
    public required string ConnectionString { get; set; }

    /// <summary>
    /// Логировать запросы (optional)?
    /// По умолчанию false.
    /// </summary>
    public bool LogQueries { get; set; }
}