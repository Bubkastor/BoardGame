using BoardGame.Document;
using BoardGame.Model;
using BoardGame.Model.Tiles;

namespace BoardGame.Repository
{
    public class PlayFieldTilRepository : IPlayFieldTilRepository
    {
        private List<PlayFieldTil> _playFieldTils = new List<PlayFieldTil>()
        {
            new PlayFieldTil()
            {
                Id = 1,
                NodeCount = 3,
                Type = TileType.Green,
                Visible = false,
                NodeProps = new List<NodeProp>()
                {
                    new NodeProp()
                    {
                        IdNode = 1,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.Creature,
                        NeighborsNode = [ HelpClass.TOP_RIGHT_SIDE,HelpClass.TOP_RIGHT_SIDE_V2, HelpClass.RIGHT_SIDE, HelpClass.TOP_LEFT_SIDE,HelpClass.TOP_LEFT_SIDE_V2, 2, 3]

                    },
                    new NodeProp()
                    {
                        IdNode = 2,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.RIGHT_SIDE, HelpClass.RIGHT_SIDE_V2, HelpClass.BOTTOM_RIGHT_SIDE,HelpClass.BOTTOM_RIGHT_SIDE_V2, HelpClass.BOTTOM_LEFT_SIDE_V2, 1, 3]
                    },
                    new NodeProp()
                    {
                        IdNode = 3,
                        DifficultyAreaType = DifficultyAreaType.Crossed,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.BOTTOM_LEFT_SIDE, HelpClass.BOTTOM_LEFT_SIDE_V2, HelpClass.LEFT_SIDE,HelpClass.LEFT_SIDE_V2, HelpClass.TOP_LEFT_SIDE_V2, 1, 2]
                    }
                }
            },
            new PlayFieldTil()
            {
                Id = 2,
                NodeCount = 4,
                Type = TileType.Green,
                Visible = false,
                NodeProps = new List<NodeProp>()
                {
                    new NodeProp()
                    {
                        IdNode = 1,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.Creature,
                        NeighborsNode = [ HelpClass.TOP_RIGHT_SIDE, HelpClass.LEFT_SIDE, HelpClass.LEFT_SIDE_V2, HelpClass.TOP_LEFT_SIDE,HelpClass.TOP_LEFT_SIDE_V2, 2, 3, 4]
                    },
                    new NodeProp()
                    {
                        IdNode = 2,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.TOP_RIGHT_SIDE,HelpClass.TOP_RIGHT_SIDE_V2, HelpClass.RIGHT_SIDE, 1, 3]
                    },
                    new NodeProp()
                    {
                        IdNode = 3,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.Settlement,
                        MonsterType = NpcType.None,
                        Meet = new Meet()
                        {
                            Name = "Эшбери-Роуд",
                            Lvl = 1
                        },
                        NeighborsNode = [ HelpClass.RIGHT_SIDE_V2, HelpClass.BOTTOM_RIGHT_SIDE, 1, 2, 4 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 4,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.BOTTOM_RIGHT_SIDE, HelpClass.BOTTOM_RIGHT_SIDE_V2, HelpClass.BOTTOM_LEFT_SIDE, HelpClass.BOTTOM_LEFT_SIDE_V2, HelpClass.LEFT_SIDE_V2, 1, 3 ]
                    }
                }
            },
            new PlayFieldTil()
            {
                Id = 3,
                NodeCount = 4,
                Type = TileType.Green,
                Visible = false,
                NodeProps = new List<NodeProp>()
                {
                    new NodeProp()
                    {
                        IdNode = 1,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.TOP_RIGHT_SIDE,HelpClass.TOP_RIGHT_SIDE_V2, HelpClass.TOP_LEFT_SIDE, HelpClass.RIGHT_SIDE, 2 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 2,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.Human,
                        NeighborsNode = [ HelpClass.TOP_LEFT_SIDE_V2, HelpClass.RIGHT_SIDE, HelpClass.RIGHT_SIDE_V2, HelpClass.BOTTOM_RIGHT_SIDE, 1, 3, 4 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 3,
                        DifficultyAreaType = DifficultyAreaType.Radiation,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.BOTTOM_RIGHT_SIDE, HelpClass.BOTTOM_RIGHT_SIDE_V2, HelpClass.BOTTOM_LEFT_SIDE, HelpClass.BOTTOM_LEFT_SIDE_V2, HelpClass.LEFT_SIDE_V2, 2, 4 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 4,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.Wasteland,
                        Meet = new Meet()
                        {
                            Name = "Заправка Красная ракет",
                            Lvl = 2,
                        },
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.TOP_LEFT_SIDE_V2, HelpClass.LEFT_SIDE, HelpClass.LEFT_SIDE_V2, 2, 3 ]
                    }
                }
            },
            new PlayFieldTil()
            {
                Id = 4,
                NodeCount = 4,
                Type = TileType.Green,
                Visible = false,
                NodeProps = new List<NodeProp>()
                {
                    new NodeProp()
                    {
                        IdNode = 1,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.TOP_RIGHT_SIDE, HelpClass.TOP_RIGHT_SIDE_V2, HelpClass.TOP_LEFT_SIDE, HelpClass.TOP_LEFT_SIDE_V2, HelpClass.RIGHT_SIDE, 2, 3, 4]
                    },
                    new NodeProp()
                    {
                        IdNode = 2,
                        DifficultyAreaType = DifficultyAreaType.Crossed,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.RIGHT_SIDE, HelpClass.RIGHT_SIDE_V2, HelpClass.BOTTOM_RIGHT_SIDE, HelpClass.BOTTOM_RIGHT_SIDE_V2,HelpClass.BOTTOM_LEFT_SIDE_V2, 1, 3, 4]
                    },
                    new NodeProp()
                    {
                        IdNode = 3,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.TOP_LEFT_SIDE_V2, HelpClass.LEFT_SIDE,HelpClass.LEFT_SIDE_V2,HelpClass.BOTTOM_LEFT_SIDE, HelpClass.BOTTOM_LEFT_SIDE_V2, 1, 2, 4 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 4,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.Wasteland,
                        MonsterType = NpcType.Human,
                        Meet = new Meet()
                        {
                            Name = "Лагерь Рейдоров",
                            Lvl = 3
                        },
                        NeighborsNode = [ 1, 2, 3 ]
                    }
                }
            },
            new PlayFieldTil()
            {
                Id = 5,
                NodeCount = 4,
                Type = TileType.Green,
                Visible = false,
                NodeProps = new List<NodeProp>()
                {
                    new NodeProp()
                    {
                        IdNode = 1,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.Wasteland,
                        MonsterType = NpcType.Human,
                        Meet = new Meet()
                        {
                            Name = "Супермакрет",
                            Lvl = 2
                        },
                        NeighborsNode = [ HelpClass.TOP_RIGHT_SIDE, HelpClass.TOP_LEFT_SIDE, HelpClass.TOP_LEFT_SIDE_V2, 2, 3, 4]
                    },
                    new NodeProp()
                    {
                        IdNode = 2,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [HelpClass.TOP_LEFT_SIDE, HelpClass.TOP_LEFT_SIDE_V2, HelpClass.RIGHT_SIDE, HelpClass.RIGHT_SIDE_V2, HelpClass.BOTTOM_RIGHT_SIDE, 1, 3]
                    },
                    new NodeProp()
                    {
                        IdNode = 3,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.BOTTOM_RIGHT_SIDE, HelpClass.BOTTOM_RIGHT_SIDE_V2, HelpClass.BOTTOM_LEFT_SIDE_V2, 1, 2, 4 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 4,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.Human,
                        NeighborsNode = [ HelpClass.BOTTOM_LEFT_SIDE, HelpClass.BOTTOM_LEFT_SIDE_V2, HelpClass.LEFT_SIDE, HelpClass.LEFT_SIDE_V2, HelpClass.TOP_LEFT_SIDE_V2, 1, 3 ]
                    }
                }
            },
            new PlayFieldTil()
            {
                Id = 6,
                NodeCount = 3,
                Type = TileType.Green,
                Visible = false,
                NodeProps = new List<NodeProp>()
                {
                    new NodeProp()
                    {
                        IdNode = 1,
                        DifficultyAreaType = DifficultyAreaType.Radiation,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.TOP_RIGHT_SIDE, HelpClass.TOP_LEFT_SIDE, HelpClass.TOP_LEFT_SIDE_V2, HelpClass.LEFT_SIDE,HelpClass.LEFT_SIDE_V2, HelpClass.BOTTOM_LEFT_SIDE, HelpClass.BOTTOM_LEFT_SIDE_V2, 2, 3]
                    },
                    new NodeProp()
                    {
                        IdNode = 2,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [HelpClass.TOP_LEFT_SIDE, HelpClass.TOP_LEFT_SIDE_V2, HelpClass.RIGHT_SIDE, HelpClass.RIGHT_SIDE_V2, HelpClass.BOTTOM_RIGHT_SIDE, 1, 3]
                    },
                    new NodeProp()
                    {
                        IdNode = 3,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.Settlement,
                        MonsterType = NpcType.None,
                         Meet = new Meet()
                        {
                            Name = "Ферма Хофмана",
                            Lvl = 2
                        },
                        NeighborsNode = [ HelpClass.BOTTOM_RIGHT_SIDE, HelpClass.BOTTOM_RIGHT_SIDE_V2, HelpClass.BOTTOM_LEFT_SIDE_V2, 1, 2 ]
                    }
                }
            },
            new PlayFieldTil()
            {
                Id = 7,
                NodeCount = 5,
                Type = TileType.Green,
                Visible = false,
                NodeProps = new List<NodeProp>()
                {
                    new NodeProp()
                    {
                        IdNode = 1,
                        DifficultyAreaType = DifficultyAreaType.Crossed,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.TOP_RIGHT_SIDE, HelpClass.TOP_LEFT_SIDE, HelpClass.TOP_LEFT_SIDE, 2, 3]
                    },
                    new NodeProp()
                    {
                        IdNode = 2,
                        DifficultyAreaType = DifficultyAreaType.Crossed,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [HelpClass.TOP_RIGHT_SIDE, HelpClass.TOP_RIGHT_SIDE_V2, HelpClass.RIGHT_SIDE, 1, 3]
                    },
                    new NodeProp()
                    {
                        IdNode = 3,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.Wasteland,
                        MonsterType = NpcType.None,
                        Meet = new Meet()
                        {
                            Name = "Шоссе 74",
                            Lvl = 1
                        },
                        NeighborsNode = [ HelpClass.TOP_LEFT_SIDE_V2, HelpClass.LEFT_SIDE, HelpClass.LEFT_SIDE_V2, HelpClass.RIGHT_SIDE, HelpClass.RIGHT_SIDE_V2, HelpClass.BOTTOM_RIGHT_SIDE, 1, 2, 4, 5 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 4,
                        DifficultyAreaType = DifficultyAreaType.Radiation,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [HelpClass.BOTTOM_RIGHT_SIDE, HelpClass.BOTTOM_RIGHT_SIDE_V2, HelpClass.LEFT_SIDE_V2, 2, 5 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 5,
                        DifficultyAreaType = DifficultyAreaType.Radiation,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [HelpClass.BOTTOM_LEFT_SIDE, HelpClass.BOTTOM_LEFT_SIDE_V2, HelpClass.LEFT_SIDE_V2, 4, 3 ]
                    },
                },
            },
            new PlayFieldTil()
            {
                Id = 8,
                NodeCount = 5,
                Type = TileType.Green,
                Visible = false,
                NodeProps = new List<NodeProp>()
                {
                    new NodeProp()
                    {
                        IdNode = 1,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.Creature,
                        NeighborsNode = [ HelpClass.TOP_RIGHT_SIDE, HelpClass.TOP_LEFT_SIDE, HelpClass.TOP_LEFT_SIDE_V2, 2, 3, 4, 5 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 2,
                        DifficultyAreaType = DifficultyAreaType.Crossed,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [HelpClass.TOP_RIGHT_SIDE,HelpClass.TOP_RIGHT_SIDE_V2, HelpClass.RIGHT_SIDE, 1, 3 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 3,
                        DifficultyAreaType = DifficultyAreaType.Crossed,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [ HelpClass.RIGHT_SIDE, HelpClass.RIGHT_SIDE_V2, HelpClass.BOTTOM_RIGHT_SIDE, 1, 2 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 4,
                        DifficultyAreaType = DifficultyAreaType.Crossed,
                        MeetType = MeetType.None,
                        MonsterType = NpcType.None,
                        NeighborsNode = [HelpClass.BOTTOM_LEFT_SIDE, HelpClass.BOTTOM_LEFT_SIDE_V2, HelpClass.LEFT_SIDE_V2, 1, 5 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 5,
                        DifficultyAreaType = DifficultyAreaType.Crossed,
                        MeetType = MeetType.Vault84,
                        MonsterType = NpcType.None,
                        NeighborsNode = [HelpClass.LEFT_SIDE, HelpClass.LEFT_SIDE_V2, HelpClass.TOP_LEFT_SIDE_V2, 1, 4 ]
                    },
                },
            },

        };
        public PlayFieldTil GetPlayFieldTilById(int id)
        {
            return _playFieldTils.Where(x => x.Id == id).First();
        }

        public List<PlayFieldTil> GetPlayFieldTilByTileType(TileType tileType)
        {
            return _playFieldTils.Where(x => x.Type == tileType).ToList();
        }

        public List<PlayFieldTil> GetPlayFieldTils()
        {
            return _playFieldTils;
        }
    }
}
