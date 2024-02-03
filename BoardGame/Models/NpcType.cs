using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model
{
    /// <summary>
    /// Тип npc
    /// </summary>
    public enum NpcType
    {
        None,

        /// <summary>
        /// Существо
        /// </summary>
        Creature,

        /// <summary>
        /// Люди
        /// </summary>
        Human,

        /// <summary>
        /// Роботы
        /// </summary>
        Robot,

        /// <summary>
        /// Монстры
        /// </summary>
        Monster,

        /// <summary>
        /// СуперМутант
        /// </summary>
        SuperMutant,

        /// <summary>
        /// Звезда
        /// </summary>
        Star,

        /// <summary>
        /// Щит
        /// </summary>
        Shield
    }
}
