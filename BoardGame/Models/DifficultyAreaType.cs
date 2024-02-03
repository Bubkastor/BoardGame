using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model
{
    /// <summary>
    /// Сложность тайла
    /// </summary>
    public enum DifficultyAreaType
    {
        None,
        /// <summary>
        /// Радиктивная
        /// </summary>
        Radiation,

        /// <summary>
        /// Сложная местность
        /// </summary>
        Crossed
    }
}
