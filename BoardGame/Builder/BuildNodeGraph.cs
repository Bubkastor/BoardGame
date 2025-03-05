using BoardGame.Document;
using BoardGame.Model.Map;
using BoardGame.Model.Tiles;
using BoardGame.Models.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Builder
{
    internal class BuildNodeGraph : IBuildNodeGraph
    {
        public void AddBottomLeft(IMap root, int idPlayFieldTil, PlayFieldTil playFieldTil)
        {
            Dictionary<double, double> reversSide = new Dictionary<double, double>()
            {
                { TileSide.BOTTOM_LEFT_SIDE, TileSide.TOP_RIGHT_SIDE},
                { TileSide.BOTTOM_LEFT_SIDE_V2 , TileSide.TOP_RIGHT_SIDE_V2 }
            };

            Connect(root, idPlayFieldTil, playFieldTil, reversSide);
        }

        public void AddBottomRight(IMap root, int idPlayFieldTil, PlayFieldTil playFieldTil)
        {
            Dictionary<double, double> reversSide = new Dictionary<double, double>()
            {
                { TileSide.BOTTOM_RIGHT_SIDE, TileSide.TOP_LEFT_SIDE},
                { TileSide.BOTTOM_RIGHT_SIDE_V2 , TileSide.TOP_LEFT_SIDE_V2 }
            };

            Connect(root, idPlayFieldTil, playFieldTil, reversSide);
        }

        public void AddLeft(IMap root, int idPlayFieldTil, PlayFieldTil playFieldTil)
        {
            Dictionary<double, double> reversSide = new Dictionary<double, double>()
            {
                { TileSide.LEFT_SIDE, TileSide.RIGHT_SIDE },
                { TileSide.LEFT_SIDE_V2 , TileSide.RIGHT_SIDE_V2 }
            };

            Connect(root, idPlayFieldTil, playFieldTil, reversSide);
        }

        public void AddRight(IMap root, int idPlayFieldTil, PlayFieldTil playFieldTil)
        {
            Dictionary<double, double> reversSide = new Dictionary<double, double>()
            {
                { TileSide.RIGHT_SIDE, TileSide.LEFT_SIDE },
                { TileSide.RIGHT_SIDE_V2, TileSide.LEFT_SIDE_V2 },
            };

            Connect(root, idPlayFieldTil, playFieldTil, reversSide);
        }

      

        public void AddTopLeft(IMap root, int idPlayFieldTil, PlayFieldTil playFieldTil)
        {
            Dictionary<double, double> reversSide = new Dictionary<double, double>()
            {
                { TileSide.TOP_LEFT_SIDE , TileSide.BOTTOM_RIGHT_SIDE},
                { TileSide.TOP_LEFT_SIDE_V2 , TileSide.BOTTOM_RIGHT_SIDE_V2 }
            };

            Connect(root, idPlayFieldTil, playFieldTil, reversSide);
        }

        public void AddTopRight(IMap root, int idPlayFieldTil, PlayFieldTil playFieldTil)
        {
            Dictionary<double, double> reversSide = new Dictionary<double, double>()
            {
                { TileSide.TOP_RIGHT_SIDE, TileSide.BOTTOM_LEFT_SIDE},
                { TileSide.TOP_RIGHT_SIDE_V2 , TileSide.BOTTOM_LEFT_SIDE_V2 }
            };

            Connect(root, idPlayFieldTil, playFieldTil, reversSide);
        }

        public IMap Create(PlayFieldTil playFieldTils)
        {
            var result = new Node();
            Dictionary<CoordinatePoint, Node> keyValues = new Dictionary<CoordinatePoint, Node>();
            if (playFieldTils.Visible) 
            { 
                foreach (NodeProp item in playFieldTils.NodeProps)
                {
                    var coord = new CoordinatePoint(playFieldTils.Id, item.IdNode);
                    keyValues.Add(coord, new Node()
                    {
                        Coordinate = coord,
                        Neighbors = new List<Node>(),
                        Side = item.NeighborsNode,
                        DifficultyAreaType = item.DifficultyAreaType
                    });
                }
            }
            else
            {
                var coord = new CoordinatePoint(playFieldTils.Id, 0);
                keyValues.Add(coord, new Node()
                {
                    Coordinate = coord,
                    Neighbors = new List<Node>(),
                    Side = TileSide.AllSide.ToList(),
                    DifficultyAreaType = Model.DifficultyAreaType.None
                });
            }

            foreach (var key in keyValues.Keys)
            {
                var node = keyValues[key];
                result = node;
                for (int i = 0; i < node.Side.Count; i++)
                {
                    int side = (int)node.Side[i];
                    if (side > 0 && side != key.IdNode)
                    {
                        result.Neighbors.Add(keyValues[new CoordinatePoint(key.IdPlayFieldTil, side)]);
                    }
                }
                node.Side = node.Side.Where(x => x < 0).ToList();
            }

            return new Map(result, keyValues);
        }

        private void Connect(IMap root, int idPlayFieldTil, PlayFieldTil playFieldTils, Dictionary<double, double> reversSide)
        {
            IMap second;
            if (root.NodeList.ContainsKey(new CoordinatePoint(playFieldTils.Id, playFieldTils.NodeProps[0].IdNode)))
            {
                second = root;
            }
            else
            {
                second = Create(playFieldTils);
            }

            var nodeSideConnect = new List<Node>();
            var nodeSideConnectV2 = new List<Node>();

            foreach (var key in root.NodeList.Keys)
            {
                var item = root.NodeList[key];
                if (item.Coordinate.IdPlayFieldTil != idPlayFieldTil)
                {
                    continue;
                }
                if (item.Side.Contains(reversSide.Keys.First()))
                {
                    nodeSideConnect.Add(item);
                    item.Side.RemoveAll(x => x == reversSide.Keys.First());
                }
                if (item.Side.Contains(reversSide.Keys.Last()))
                {
                    nodeSideConnectV2.Add(item);
                    item.Side.RemoveAll(x => x == reversSide.Keys.Last());
                }
            };

            foreach (var key in second.NodeList.Keys)
            {
                var secondNode = second.NodeList[key];
                if (playFieldTils.Id != secondNode.Coordinate.IdPlayFieldTil)
                {
                    continue;
                }
                var rever = reversSide[reversSide.Keys.First()];

                if (secondNode.Side.Contains(rever))
                {
                    foreach (var nodeSC in nodeSideConnect)
                    {
                        if (!nodeSC.Neighbors.Contains(secondNode))
                        {
                            nodeSC.Neighbors.Add(secondNode);
                        }
                        if (!secondNode.Neighbors.Contains(nodeSC))
                        {
                            secondNode.Neighbors.Add(nodeSC);
                        }
                    }
                    secondNode.Side.RemoveAll(x => x == rever);
                }

                var reverV2 = reversSide[reversSide.Keys.Last()];
                if (secondNode.Side.Contains(reverV2))
                {
                    foreach (var nodeSCV2 in nodeSideConnectV2)
                    {
                        if (!nodeSCV2.Neighbors.Contains(secondNode))
                        {
                            nodeSCV2.Neighbors.Add(secondNode);
                        }
                        if (!secondNode.Neighbors.Contains(nodeSCV2))
                        {
                            secondNode.Neighbors.Add(nodeSCV2);
                        }

                    }
                    secondNode.Side.RemoveAll(x => x == reverV2);
                }
            }

            foreach (var key in second.NodeList.Keys)
            {
                root.NodeList.TryAdd(key, second.NodeList[key]);
            }
        }
    }
}
