using BoardGame.Document;
using BoardGame.Model;
using BoardGame.Model.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        MonsterType = MonsterType.Creature,
                        NeighborsNode = [ Help.TOP_RIGHT_SIDE, Help.TOP_LEFT_SIDE, Help.RIGHT_SIDE, 2, 3]

                    },
                    new NodeProp()
                    {
                        IdNode = 2,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = MonsterType.None,
                        NeighborsNode = [ Help.RIGHT_SIDE, Help.BOTTOM_RIGHT_SIDE, Help.BOTTOM_LEFT_SIDE, 1, 3]
                    },
                    new NodeProp()
                    {
                        IdNode = 3,
                        DifficultyAreaType = DifficultyAreaType.Crossed,
                        MeetType = MeetType.None,
                        MonsterType = MonsterType.None,
                        NeighborsNode = [ Help.BOTTOM_LEFT_SIDE, Help.LEFT_SIDE, Help.TOP_LEFT_SIDE, 1, 2]
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
                        MonsterType = MonsterType.Creature,
                        NeighborsNode = [ Help.TOP_RIGHT_SIDE, Help.LEFT_SIDE, Help.TOP_LEFT_SIDE, 2, 3, 4]
                    },
                    new NodeProp()
                    {
                        IdNode = 2,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = MonsterType.None,
                        NeighborsNode = [ Help.TOP_RIGHT_SIDE, Help.RIGHT_SIDE, 1, 3]
                    },
                    new NodeProp()
                    {
                        IdNode = 3,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.Settlement,
                        MonsterType = MonsterType.None,
                        Meet = new Meet()
                        {
                            Name = "Эшбери-Роуд",
                            Lvl = 1
                        },
                        NeighborsNode = [ Help.RIGHT_SIDE, Help.BOTTOM_RIGHT_SIDE, 1, 2, 4 ]
                    },
                    new NodeProp()
                    {
                        IdNode = 4,
                        DifficultyAreaType = DifficultyAreaType.None,
                        MeetType = MeetType.None,
                        MonsterType = MonsterType.None,
                        NeighborsNode = [ Help.BOTTOM_RIGHT_SIDE, Help.BOTTOM_LEFT_SIDE, Help.LEFT_SIDE, 1, 3 ]
                    }
                }
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

        public List<PlayFieldTil> GetPlayFieldTils()
        {
            return _playFieldTils;
        }
    }
}
