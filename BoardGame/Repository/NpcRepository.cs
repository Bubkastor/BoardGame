using BoardGame.Model;
using BoardGame.Model.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Repository
{
    public class NpcRepository : INpcRepository
    {
        private List<Npc> _npcs = new List<Npc>()
        {
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Сияющий",
                EnemyType = NpcType.Monster,
                Vulnerability = Vulnerability.Head,
                Properties = NpcProperties.Aggressive | NpcProperties.Radioactive
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 3,
                Name = "Коготь смерти",
                EnemyType = NpcType.Monster,
                Vulnerability = Vulnerability.Hands,
                Properties = NpcProperties.Booty | NpcProperties.Aggressive
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 3,
                Name = "Коготь смерти",
                EnemyType = NpcType.Monster,
                Vulnerability = Vulnerability.Hands,
                Properties = NpcProperties.Booty | NpcProperties.Aggressive
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Яо гай",
                EnemyType = NpcType.Monster,
                Vulnerability = Vulnerability.Body,
                Properties = NpcProperties.Armor | NpcProperties.Aggressive
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 3,
                Name = "Супермутант-Налетчик",
                EnemyType = NpcType.SuperMutant,
                Vulnerability = Vulnerability.Head | Vulnerability.Hands,
                Properties = NpcProperties.Booty | NpcProperties.LongRange
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 3,
                Name = "Супермутант-Бестия",
                EnemyType = NpcType.SuperMutant,
                Vulnerability = Vulnerability.Body,
                Properties = NpcProperties.Booty | NpcProperties.Aggressive
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 3,
                Name = "Супермутант-Бестия",
                EnemyType = NpcType.SuperMutant,
                Vulnerability = Vulnerability.Body,
                Properties = NpcProperties.Booty | NpcProperties.Aggressive
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 3,
                Name = "Супермутант-Бос",
                EnemyType = NpcType.SuperMutant,
                Vulnerability = Vulnerability.Head,
                Properties = NpcProperties.Booty
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Мистер храбрец",
                EnemyType = NpcType.Robot,
                Vulnerability = Vulnerability.Hands,
                Properties = NpcProperties.LongRange
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Мистер храбрец",
                EnemyType = NpcType.Robot,
                Vulnerability = Vulnerability.Hands,
                Properties = NpcProperties.LongRange
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 3,
                Name = "Робот-охраник",
                EnemyType = NpcType.Robot,
                Vulnerability = Vulnerability.Hands | Vulnerability.Body,
                Properties = NpcProperties.Aggressive | NpcProperties.LongRange
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Протектрон-медик",
                EnemyType = NpcType.Robot,
                Vulnerability = Vulnerability.Hands | Vulnerability.Body,
                Properties = NpcProperties.Booty | NpcProperties.Armor
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 1,
                Name = "Дутень",
                EnemyType = NpcType.Creature,
                Vulnerability = Vulnerability.Head | Vulnerability.Body,
                Properties = NpcProperties.Booty
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 1,
                Name = "Радтаракан",
                EnemyType = NpcType.Creature,
                Vulnerability = Vulnerability.Hands | Vulnerability.Legs,
                Properties = NpcProperties.Radioactive
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Дикий Гуль",
                EnemyType = NpcType.Creature,
                Vulnerability = Vulnerability.Head | Vulnerability.Body | Vulnerability.Legs,
                Properties = NpcProperties.Aggressive
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 1,
                Name = "Радскорпион",
                EnemyType = NpcType.Creature,
                Vulnerability = Vulnerability.Hands | Vulnerability.Legs,
                Properties = NpcProperties.Aggressive | NpcProperties.Escape
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 1,
                Name = "Радскорпион",
                EnemyType = NpcType.Creature,
                Vulnerability = Vulnerability.Hands | Vulnerability.Legs,
                Properties = NpcProperties.Aggressive | NpcProperties.Escape
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Жалокрыл",
                EnemyType = NpcType.Creature,
                Vulnerability = Vulnerability.Head | Vulnerability.Body,
                Properties = NpcProperties.None
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Жалокрыл",
                EnemyType = NpcType.Creature,
                Vulnerability = Vulnerability.Head | Vulnerability.Body,
                Properties = NpcProperties.None
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 1,
                Name = "Кротокрыс",
                EnemyType = NpcType.Creature,
                Vulnerability = Vulnerability.Body,
                Properties = NpcProperties.Escape
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 1,
                Name = "Мародер",
                EnemyType = NpcType.Human,
                Vulnerability = Vulnerability.Legs,
                Properties = NpcProperties.Booty | NpcProperties.Escape
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Охотник за головами",
                EnemyType = NpcType.Human,
                Vulnerability = Vulnerability.Hands | Vulnerability.Legs,
                Properties = NpcProperties.Booty | NpcProperties.LongRange
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Регулятор",
                EnemyType = NpcType.Human,
                Vulnerability = Vulnerability.Body | Vulnerability.Legs,
                Properties = NpcProperties.Booty | NpcProperties.LongRange
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 1,
                Name = "Рейдер-тварь",
                EnemyType = NpcType.Human,
                Vulnerability = Vulnerability.Body | Vulnerability.Head,
                Properties = NpcProperties.Armor | NpcProperties.LongRange
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 1,
                Name = "Рейдер-тварь",
                EnemyType = NpcType.Human,
                Vulnerability = Vulnerability.Body | Vulnerability.Head,
                Properties = NpcProperties.Armor | NpcProperties.LongRange
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Рейдер-Псих",
                EnemyType = NpcType.Human,
                Vulnerability = Vulnerability.Body | Vulnerability.Legs,
                Properties = NpcProperties.Booty | NpcProperties.LongRange
            },
            new Npc()
            {
                IsActive = true,
                Lvl = 2,
                Name = "Рейдер-Псих",
                EnemyType = NpcType.Human,
                Vulnerability = Vulnerability.Body | Vulnerability.Legs,
                Properties = NpcProperties.Booty | NpcProperties.LongRange
            },
        };

        public Npc GetEnymyByKind(NpcType npcType)
        {
            return _npcs.Where(x => x.EnemyType == npcType).First();
        }
    }
}
