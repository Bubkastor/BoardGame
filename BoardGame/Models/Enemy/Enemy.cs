using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model.Enemy
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Lvl { get; set; }
        public MonsterType EnemyType { get; set; }

        //<summary>
        // Уязвимость
        //</summary>
        public Body Vulnerability { get; init; }

        //<summary>
        // Свойства
        //</summary>
        public List<Properties> Properties { get; init; }

        //<summary>
        // Активная ли карта
        //</summary>
        public bool IsActive { get; set; }
    }
}
