using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Document
{
    /// <summary>
    /// Стороны тайла
    ///     -6     /  \   -1
    ///     -6.5  /    \  -1.5
    ///     -5   |     |  -2
    ///     -5.5 |     |  -2.5
    ///     -4    \   /   -3
    ///     -4.5   \ /    -3.5
    /// </summary>
    public static class HelpClass
    {
        /// <summary>
        /// \   -1
        /// </summary>
        public const double TOP_RIGHT_SIDE = -1;

        /// <summary>
        /// \  -1.5
        /// </summary>
        public const double TOP_RIGHT_SIDE_V2 = -1.5;

        /// <summary>
        /// |  -2
        /// </summary>
        public const double RIGHT_SIDE = -2;

        /// <summary>
        /// |  -2.5
        /// </summary>
        public const double RIGHT_SIDE_V2 = -2.5;

        /// <summary>
        /// /   -3
        /// </summary>
        public const double BOTTOM_RIGHT_SIDE = -3;

        /// <summary>
        /// /    -3.5
        /// </summary>
        public const double BOTTOM_RIGHT_SIDE_V2 = -3.5;

        /// <summary>
        /// -4.5   \
        /// </summary>
        public const double BOTTOM_LEFT_SIDE = -4;

        /// <summary>
        /// -4    \
        /// </summary>
        public const double BOTTOM_LEFT_SIDE_V2 = -4.5;

        /// <summary>
        /// -5.5 |
        /// </summary>
        public const double LEFT_SIDE = -5;

        /// <summary>
        /// -5   | 
        /// </summary>
        public const double LEFT_SIDE_V2 = -5.5;

        /// <summary>
        /// -6.5  / 
        /// </summary>
        public const double TOP_LEFT_SIDE = -6;

        /// <summary>
        /// -6     /
        /// </summary>
        public const double TOP_LEFT_SIDE_V2 = -6.5;
    }
}
