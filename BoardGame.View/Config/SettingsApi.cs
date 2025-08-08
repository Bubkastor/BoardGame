using System.ComponentModel.DataAnnotations;

namespace BoardGame.View.Config
{
    public class SettingsApi
    {
        /// Строка настроек подключения к api (required).
        /// </summary>
        [Required]
        public required string ConnectionString { get; set; }

    }
}
