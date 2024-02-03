using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model
{
    public enum MeetType
    {
        None,

        /// <summary>
        /// Поселение
        /// </summary>
        Settlement,
        /// <summary>
        /// Пустошь
        /// </summary>
        Wasteland,

        /// <summary>
        /// Убежище 84
        /// </summary>
        Vault84,

        /// <summary>
        /// Убежище 109
        /// </summary>
        Vault109
    }
}
