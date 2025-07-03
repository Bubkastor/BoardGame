using BoardGame.Models.Enemy;

namespace BoardGame.Models.Repository;

public interface INpcRepository
{
    Npc GetEnemyByKind(NpcType npcType);
}
