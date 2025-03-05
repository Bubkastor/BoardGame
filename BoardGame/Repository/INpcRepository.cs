using BoardGame.Model;
using BoardGame.Model.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Repository
{
    public interface INpcRepository
    {
        Npc GetEnemyByKind(NpcType npcType);
    }
}
