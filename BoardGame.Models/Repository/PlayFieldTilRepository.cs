﻿using BoardGame.Models.Tiles;

namespace BoardGame.Models.Repository;

public class PlayFieldTilRepository : IPlayFieldTilRepository
{
    private List<PlayFieldTil> _playFieldTils = new List<PlayFieldTil>()
    {
        // green
        new PlayFieldTil()
        {
            Id = 1,
            Img = "Id1.png",
            Type = TileType.Green,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    NpcType = NpcType.Creature,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.RIGHT_SIDE,
                        TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2, 2, 3
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    NeighborsNode =
                    [
                        TileSide.RIGHT_SIDE, TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE,
                        TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE_V2, 1, 3
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    DifficultyAreaType = DifficultyAreaType.Crossed,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_LEFT_SIDE, TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE,
                        TileSide.LEFT_SIDE_V2, TileSide.TOP_LEFT_SIDE_V2, 1, 2
                    ]
                }
            }
        },
        new PlayFieldTil()
        {
            Id = 2,
            Img = "Id2.png",
            Type = TileType.Green,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    NpcType = NpcType.Creature,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, TileSide.TOP_LEFT_SIDE,
                        TileSide.TOP_LEFT_SIDE_V2, 2, 3, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    NeighborsNode = [TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.RIGHT_SIDE, 1, 3]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    MeetType = MeetType.Settlement,
                    Meet = new Meet()
                    {
                        Name = "Эшбери-Роуд",
                        Lvl = 1
                    },
                    NeighborsNode = [TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 1, 2, 4]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE,
                        TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE_V2, 1, 3
                    ]
                }
            }
        },
        new PlayFieldTil()
        {
            Id = 3,
            Img = "Id3.png",
            Type = TileType.Green,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.TOP_LEFT_SIDE,
                        TileSide.RIGHT_SIDE, 2
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    NpcType = NpcType.Human,
                    NeighborsNode =
                    [
                        TileSide.TOP_LEFT_SIDE_V2, TileSide.RIGHT_SIDE, TileSide.RIGHT_SIDE_V2,
                        TileSide.BOTTOM_RIGHT_SIDE, 1, 3, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE,
                        TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE_V2, 2, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    MeetType = MeetType.Wasteland,
                    Meet = new Meet()
                    {
                        Name = "Заправка Красная ракет",
                        Lvl = 2,
                    },
                    NeighborsNode = [TileSide.TOP_LEFT_SIDE_V2, TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, 2, 3]
                }
            }
        },
        new PlayFieldTil()
        {
            Id = 4,
            Img = "Id4.png",
            Type = TileType.Green,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.TOP_LEFT_SIDE,
                        TileSide.TOP_LEFT_SIDE_V2, TileSide.RIGHT_SIDE, 2, 3, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    DifficultyAreaType = DifficultyAreaType.Crossed,
                    NeighborsNode =
                    [
                        TileSide.RIGHT_SIDE, TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE,
                        TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE_V2, 1, 3, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    NeighborsNode =
                    [
                        TileSide.TOP_LEFT_SIDE_V2, TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2,
                        TileSide.BOTTOM_LEFT_SIDE, TileSide.BOTTOM_LEFT_SIDE_V2, 1, 2, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    MeetType = MeetType.Wasteland,
                    NpcType = NpcType.Human,
                    Meet = new Meet()
                    {
                        Name = "Лагерь Рейдоров",
                        Lvl = 3
                    },
                    NeighborsNode = [1, 2, 3]
                }
            }
        },
        new PlayFieldTil()
        {
            Id = 5,
            Img = "Id5.png",
            Type = TileType.Green,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    MeetType = MeetType.Wasteland,
                    NpcType = NpcType.Human,
                    Meet = new Meet()
                    {
                        Name = "Супермакрет",
                        Lvl = 2
                    },
                    NeighborsNode =
                        [TileSide.TOP_RIGHT_SIDE, TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2, 2, 3, 4]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    NeighborsNode =
                    [
                        TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2, TileSide.RIGHT_SIDE,
                        TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 1, 3
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE_V2, 1,
                        2, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    NpcType = NpcType.Human,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_LEFT_SIDE, TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE,
                        TileSide.LEFT_SIDE_V2, TileSide.TOP_LEFT_SIDE_V2, 1, 3
                    ]
                }
            }
        },
        new PlayFieldTil()
        {
            Id = 6,
            Img = "Id6.png",
            Type = TileType.Green,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2,
                        TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE,
                        TileSide.BOTTOM_LEFT_SIDE_V2, 2, 3
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,

                    NeighborsNode =
                    [
                        TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2, TileSide.RIGHT_SIDE,
                        TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 1, 3
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,

                    MeetType = MeetType.Settlement,

                    Meet = new Meet()
                    {
                        Name = "Ферма Хофмана",
                        Lvl = 2
                    },
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE_V2, 1,
                        2
                    ]
                }
            }
        },
        new PlayFieldTil()
        {
            Id = 7,
            Img = "Id7.png",
            Type = TileType.Green,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    DifficultyAreaType = DifficultyAreaType.Crossed,
                    NeighborsNode = [TileSide.TOP_RIGHT_SIDE, TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE, 2, 3]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    DifficultyAreaType = DifficultyAreaType.Crossed,
                    NeighborsNode = [TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.RIGHT_SIDE, 1, 3]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    MeetType = MeetType.Wasteland,
                    Meet = new Meet()
                    {
                        Name = "Шоссе 74",
                        Lvl = 1
                    },
                    NeighborsNode =
                    [
                        TileSide.TOP_LEFT_SIDE_V2, TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, TileSide.RIGHT_SIDE,
                        TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 1, 2, 4, 5
                    ]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                        [TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.LEFT_SIDE_V2, 2, 5]
                },
                new NodeProp()
                {
                    IdNode = 5,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                        [TileSide.BOTTOM_LEFT_SIDE, TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE_V2, 4, 3]
                },
            },
        },
        new PlayFieldTil()
        {
            Id = 8,
            Img = "Id8.png",
            Type = TileType.Green,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    NpcType = NpcType.Creature,
                    NeighborsNode =
                        [TileSide.TOP_RIGHT_SIDE, TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2, 2, 3, 4, 5]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    DifficultyAreaType = DifficultyAreaType.Crossed,
                    NeighborsNode = [TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.RIGHT_SIDE, 1, 3]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    DifficultyAreaType = DifficultyAreaType.Crossed,
                    NeighborsNode = [TileSide.RIGHT_SIDE, TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 1, 2]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    DifficultyAreaType = DifficultyAreaType.Crossed,
                    NeighborsNode =
                        [TileSide.BOTTOM_LEFT_SIDE, TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE_V2, 1, 5]
                },
                new NodeProp()
                {
                    IdNode = 5,
                    DifficultyAreaType = DifficultyAreaType.Crossed,
                    MeetType = MeetType.Vault84,
                    NeighborsNode = [TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, TileSide.TOP_LEFT_SIDE_V2, 1, 4]
                },
            },
        },
        // red
        new PlayFieldTil()
        {
            Id = 8, // red_1
            Img = "Red_1.png",
            Type = TileType.Red,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2,
                        TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, 2, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    MeetType = MeetType.Wasteland,
                    NpcType = NpcType.SuperMutant,
                    NeighborsNode =
                        [TileSide.TOP_RIGHT_SIDE, TileSide.TOP_LEFT_SIDE_V2, TileSide.RIGHT_SIDE, 1, 3, 4]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                    [
                        TileSide.RIGHT_SIDE, TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE,
                        TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE_V2, 2, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                        [TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE, TileSide.LEFT_SIDE_V2, 1, 2, 3]
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 9, // red_2
            Img = "Red_2.png",
            Type = TileType.Red,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.TOP_LEFT_SIDE,
                        TileSide.LEFT_SIDE_V2, TileSide.RIGHT_SIDE, TileSide.RIGHT_SIDE_V2,
                        TileSide.BOTTOM_RIGHT_SIDE, 2, 3
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    NpcType = NpcType.SuperMutant,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE,
                        TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE_V2, 1, 3
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    NeighborsNode = [TileSide.TOP_LEFT_SIDE_V2, TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, 1, 2, 4]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    MeetType = MeetType.Vault109,
                    NeighborsNode = [3]
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 10, // red_3
            Img = "Red_3.png",
            Type = TileType.Red,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                    [
                        TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, TileSide.TOP_LEFT_SIDE,
                        TileSide.TOP_LEFT_SIDE_V2, TileSide.TOP_RIGHT_SIDE, 2, 3, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.RIGHT_SIDE,
                        TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 1, 3, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    NpcType = NpcType.Robot,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE,
                        TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE_V2, 1, 2, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    MeetType = MeetType.Wasteland,
                    Meet = new Meet()
                    {
                        Lvl = 3,
                        Name = "Фабрика Робко"
                    },
                    NeighborsNode = [1, 2, 3]
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 11, // red_4
            Img = "Red_4.png",
            Type = TileType.Red,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    DifficultyAreaType = DifficultyAreaType.Crossed,
                    NeighborsNode =
                    [
                        TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2, TileSide.TOP_RIGHT_SIDE,
                        TileSide.TOP_LEFT_SIDE_V2, TileSide.RIGHT_SIDE, 2, 3, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    NpcType = NpcType.Monster,
                    NeighborsNode =
                    [
                        TileSide.RIGHT_SIDE, TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE,
                        TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE_V2, 1, 3
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    NeighborsNode =
                    [
                        TileSide.TOP_LEFT_SIDE_V2, TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2,
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, 1, 2
                    ]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    MeetType = MeetType.Settlement,
                    Meet = new Meet()
                    {
                        Lvl = 3,
                        Name = "Поместье Пендлтон"
                    },
                    NeighborsNode = [1]
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 12, // red_5
            Img = "Red_5.png",
            Type = TileType.Red,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    NpcType = NpcType.Human,
                    NeighborsNode =
                        [TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2, TileSide.TOP_RIGHT_SIDE, 2, 4, 5]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.RIGHT_SIDE,
                        TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 1, 3, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE_V2, 2,
                        4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    MeetType = MeetType.Settlement,
                    Meet = new Meet()
                    {
                        Lvl = 3,
                        Name = "Башня"
                    },
                    NeighborsNode =
                        [TileSide.BOTTOM_LEFT_SIDE, TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE_V2, 1, 2, 3, 5]
                },
                new NodeProp()
                {
                    IdNode = 5,
                    NeighborsNode = [TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, TileSide.TOP_LEFT_SIDE_V2, 1, 4]
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 13, // red_6
            Img = "Red_6.png",
            Type = TileType.Red,
            Visible = false,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2,
                        TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, 2, 3
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.RIGHT_SIDE,
                        TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 1, 3
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    DifficultyAreaType = DifficultyAreaType.Radiation,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE,
                        TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE_V2, 1, 2
                    ]
                }
            },
        },
        // star
        new PlayFieldTil()
        {
            Id = 14, // star_1
            Img = "Star_1.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2,
                        TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, 2, 4, 3
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.RIGHT_SIDE,
                        TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 1, 3, 4, 5
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE,
                        TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE_V2, 1, 2, 4, 5
                    ]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    DifficultyAreaType = DifficultyAreaType.Crossed,
                    NeighborsNode = [1, 2, 3, 5]
                },
                new NodeProp()
                {
                    IdNode = 5,
                    NeighborsNode = [2, 3, 4],
                    MeetType = MeetType.None,
                    Meet = new Meet()
                    {
                        Lvl = 0,
                        Name = "Лагерь на перекрёстке"
                    }
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 15, // star_2
            Img = "Star_2.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    MeetType = MeetType.Settlement,
                    Meet = new Meet()
                    {
                        Lvl = 3,
                        Name = "Подземка"
                    },
                    NeighborsNode = [TileSide.TOP_RIGHT_SIDE, TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2, 2]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    NpcType = NpcType.SuperMutant,
                    NeighborsNode =
                        [TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.RIGHT_SIDE, 1, 3, 5, 6]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    NeighborsNode =
                        [TileSide.RIGHT_SIDE, TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 2, 4, 5]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE_V2, 3,
                        5
                    ]
                },
                new NodeProp()
                {
                    IdNode = 5,
                    MeetType = MeetType.Wasteland,
                    Meet = new Meet()
                    {
                        Lvl = 4,
                        Name = "Центральный Бостон"
                    },
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, TileSide.LEFT_SIDE_V2, 2, 3, 4, 6
                    ]
                },
                new NodeProp()
                {
                    IdNode = 6,
                    NeighborsNode = [TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, TileSide.TOP_LEFT_SIDE_V2, 1, 2, 5]
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 16, // star_2_1
            Img = "Star_2_1.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    Meet = new Meet()
                    {
                        Lvl = 4,
                        Name = "Молл"
                    }
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 17, // star_2_2
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
            },
        },
        new PlayFieldTil()
        {
            Id = 18, // star_3_1
            Img = "Star_3_1.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    Meet = new Meet()
                    {
                        Lvl = 3,
                        Name = "Мегатонна"
                    }
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 19, // star_3_2
            Img = "Star_3_2.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2,
                        TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, 2, 3, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    NeighborsNode =
                    [
                        TileSide.TOP_RIGHT_SIDE, TileSide.TOP_RIGHT_SIDE_V2, TileSide.RIGHT_SIDE,
                        TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 1, 3, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE,
                        TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE_V2, 1, 2, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    MeetType = MeetType.Settlement,
                    Meet = new Meet()
                    {
                        Lvl = 4,
                        Name = "Даймон Сити"
                    },
                    NeighborsNode = [1, 2, 3]
                },
            },
        },
        new PlayFieldTil()
        {
            Id = 20, // star_4_1
            Img = "Star_4_1.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    NpcType = NpcType.Robot,
                    MeetType = MeetType.Wasteland,
                    Meet = new Meet()
                    {
                        Lvl = 4,
                        Name = "Руины тис"
                    },
                    NeighborsNode =
                    [
                        TileSide.TOP_LEFT_SIDE, TileSide.TOP_LEFT_SIDE_V2, TileSide.TOP_RIGHT_SIDE,
                        TileSide.TOP_RIGHT_SIDE_V2, TileSide.RIGHT_SIDE, 2
                    ]
                },
                new NodeProp()
                {
                    IdNode = 2,
                    NeighborsNode =
                    [
                        TileSide.TOP_LEFT_SIDE_V2, TileSide.LEFT_SIDE, TileSide.LEFT_SIDE_V2, TileSide.RIGHT_SIDE,
                        TileSide.RIGHT_SIDE_V2, TileSide.BOTTOM_RIGHT_SIDE, 1, 3, 4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 3,
                    DifficultyAreaType = DifficultyAreaType.Crossed,
                    NeighborsNode =
                    [
                        TileSide.BOTTOM_RIGHT_SIDE, TileSide.BOTTOM_RIGHT_SIDE_V2, TileSide.BOTTOM_LEFT_SIDE_V2, 2,
                        4
                    ]
                },
                new NodeProp()
                {
                    IdNode = 4,
                    NeighborsNode =
                        [TileSide.BOTTOM_LEFT_SIDE, TileSide.BOTTOM_LEFT_SIDE_V2, TileSide.LEFT_SIDE_V2, 2, 3]
                },
            },
        },
        new PlayFieldTil()
        {
            Id = 21, // star_4_2
            Img = "Star_4_2.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    Meet = new Meet()
                    {
                        Lvl = 4,
                        Name = "Проект Чистота"
                    }
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 22, // star_5_1
            Img = "Star_5_1.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    Meet = new Meet()
                    {
                        Lvl = 4,
                        Name = "Ядро"
                    }
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 23, // star_5_2
            Img = "Star_5_2.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    Meet = new Meet()
                    {
                        Lvl = 4,
                        Name = "Завод"
                    }
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 24, // star_6_1
            Img = "Star_6_1.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    Meet = new Meet()
                    {
                        Lvl = 4,
                        Name = "Мост"
                    }
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 25, // star_6_2
            Img = "Star_6_2.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    Meet = new Meet()
                    {
                        Lvl = 4,
                        Name = "Акадия"
                    }
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 26, // star_7_1
            Img = "Star_7_1.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    Meet = new Meet()
                    {
                        Lvl = 4,
                        Name = "Крепость"
                    }
                }
            },
        },
        new PlayFieldTil()
        {
            Id = 27, // star_7_2
            Img = "Star_7_2.png",
            Type = TileType.Start,
            Visible = true,
            NodeProps = new List<NodeProp>()
            {
                new NodeProp()
                {
                    IdNode = 1,
                    Meet = new Meet()
                    {
                        Lvl = 4,
                        Name = "Фар-Харбор"
                    }
                }
            },
        }
    };

    public PlayFieldTil GetPlayFieldTilById(int id)
    {
        return _playFieldTils.Where(x => x.Id == id).First();
    }

    public List<PlayFieldTil> GetPlayFieldTilByTileType(TileType tileType)
    {
        return _playFieldTils.Where(x => x.Type == tileType).ToList();
    }

    public string GetImgById(int id)
    {
        return _playFieldTils.First(x => x.Id == id).Img;
    }

    public List<PlayFieldTil> GetPlayFieldTils()
    {
        return _playFieldTils;
    }
}