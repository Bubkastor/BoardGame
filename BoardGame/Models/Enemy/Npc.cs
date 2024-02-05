using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model.Enemy
{
    public class Npc
    {
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
}
