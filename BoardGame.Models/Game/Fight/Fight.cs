using BoardGame.Models.Enemy;
using BoardGame.Models.PlayerState;

namespace BoardGame.Models.Game.Fight;

public class Fight
{
    public bool IsWinFight(Player player, Npc enamy)
    {
        Dice dice = new Dice();
        var firstDiceSide = dice.Roll;
        var secondDiceSide = dice.Roll;
        var thirdDiceSide = dice.Roll;

        player.HP.CurrentHp -= firstDiceSide.Hit * enamy.Lvl + secondDiceSide.Hit * enamy.Lvl + thirdDiceSide.Hit * enamy.Lvl;

        var npcHp = enamy.Lvl;
        if (enamy.Properties.HasFlag(NpcProperties.Armor))
        {
            npcHp += 1;
        }
        if (enamy.Properties.HasFlag(NpcProperties.LongRange) 
            && !player.Properties.HasFlag(NpcProperties.LongRange) 
            && player.Position != enamy.Position)
        {
            npcHp += 1;
        }

        if (enamy.Vulnerability.HasFlag(firstDiceSide.Vulnerability))
        {
            npcHp -= 1;
        }

        if (enamy.Vulnerability.HasFlag(secondDiceSide.Vulnerability))
        {
            npcHp -= 1;
        }

        if (enamy.Vulnerability.HasFlag(thirdDiceSide.Vulnerability))
        {
            npcHp -= 1;
        }

        if (npcHp <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
