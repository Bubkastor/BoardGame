using BoardGame.Document;
using BoardGame.Model.Map;
using BoardGame.Model.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Builder
{
    internal class BuildNodeGraph : IBuildNodeGraph
    {
        public void AddBottomLeft((Node, Dictionary<CoordinatePoint, Node>) root, int idPlayFieldTil, PlayFieldTil playFieldTils)
        {
            Dictionary<double, double> reverSide = new Dictionary<double, double>()
            {
                { HelpClass.BOTTOM_LEFT_SIDE, HelpClass.TOP_RIGHT_SIDE},
                { HelpClass.BOTTOM_LEFT_SIDE_V2 , HelpClass.TOP_RIGHT_SIDE_V2 }
            };

            Connect(root, idPlayFieldTil, playFieldTils, reverSide);
        }

        public void AddBottomRight((Node, Dictionary<CoordinatePoint, Node>) root, int idPlayFieldTil, PlayFieldTil playFieldTils)
        {
            Dictionary<double, double> reverSide = new Dictionary<double, double>()
            {
                { HelpClass.BOTTOM_RIGHT_SIDE, HelpClass.TOP_LEFT_SIDE},
                { HelpClass.BOTTOM_RIGHT_SIDE_V2 , HelpClass.TOP_LEFT_SIDE_V2 }
            };

            Connect(root, idPlayFieldTil, playFieldTils, reverSide);
        }

        public void AddLeft((Node, Dictionary<CoordinatePoint, Node>) root, int idPlayFieldTil, PlayFieldTil playFieldTils)
        {
            Dictionary<double, double> reverSide = new Dictionary<double, double>()
            {
                { HelpClass.LEFT_SIDE, HelpClass.RIGHT_SIDE },
                { HelpClass.LEFT_SIDE_V2 , HelpClass.RIGHT_SIDE_V2 }
            };

            Connect(root, idPlayFieldTil, playFieldTils, reverSide);
        }

        public void AddRight((Node, Dictionary<CoordinatePoint, Node>) root, int idPlayFieldTil, PlayFieldTil playFieldTils)
        {
            Dictionary<double, double> reverSide = new Dictionary<double, double>()
            {
                { HelpClass.RIGHT_SIDE, HelpClass.LEFT_SIDE },
                { HelpClass.RIGHT_SIDE_V2, HelpClass.LEFT_SIDE_V2 },
            };

            Connect(root, idPlayFieldTil, playFieldTils, reverSide);
        }

        private void Connect((Node, Dictionary<CoordinatePoint, Node>) root, int idPlayFieldTil, PlayFieldTil playFieldTils, Dictionary<double, double> reverSide)
        {
            (Node, Dictionary<CoordinatePoint, Node>) second = (null, null);
            if (root.Item2.ContainsKey(new CoordinatePoint(playFieldTils.Id, playFieldTils.NodeProps[0].IdNode)))
            {
                second = root;
            }
            else
            {
                second = Create(playFieldTils);
            }

            //playFieldTils.Id

            var nodeSideConnect = new List<Node>();
            var nodeSideConnectV2 = new List<Node>();

            foreach (var key in root.Item2.Keys)
            {
                var item = root.Item2[key];
                if (item.Coordinate.IdPlayFieldTil != idPlayFieldTil)
                {
                    continue;
                }
                if (item.Side.Contains(reverSide.Keys.First()))
                {
                    nodeSideConnect.Add(item);
                    item.Side.RemoveAll(x => x == reverSide.Keys.First());
                }
                if (item.Side.Contains(reverSide.Keys.Last()))
                {
                    nodeSideConnectV2.Add(item);
                    item.Side.RemoveAll(x => x == reverSide.Keys.Last());
                }
            };

            foreach (var key in second.Item2.Keys)
            {
                var leftSideNodeConnect = second.Item2[key];
                if (playFieldTils.Id != leftSideNodeConnect.Coordinate.IdPlayFieldTil)
                {
                    continue;
                }
                var rever = reverSide[reverSide.Keys.First()];

                if (leftSideNodeConnect.Side.Contains(rever))
                {
                    foreach (var nodeSC in nodeSideConnect)
                    {
                        if (!nodeSC.Neighbors.Contains(leftSideNodeConnect))
                        {
                            nodeSC.Neighbors.Add(leftSideNodeConnect);
                        }
                        if (!leftSideNodeConnect.Neighbors.Contains(nodeSC))
                        {
                            leftSideNodeConnect.Neighbors.Add(nodeSC);
                        }
                    }
                    leftSideNodeConnect.Side.RemoveAll(x => x == rever);
                }

                var reverV2 = reverSide[reverSide.Keys.Last()];
                if (leftSideNodeConnect.Side.Contains(reverV2))
                {
                    foreach (var nodeSCV2 in nodeSideConnectV2)
                    {
                        if (!nodeSCV2.Neighbors.Contains(leftSideNodeConnect))
                        {
                            nodeSCV2.Neighbors.Add(leftSideNodeConnect);
                        }
                        if (!leftSideNodeConnect.Neighbors.Contains(nodeSCV2))
                        {
                            leftSideNodeConnect.Neighbors.Add(nodeSCV2);
                        }

                    }
                    leftSideNodeConnect.Side.RemoveAll(x => x == reverV2);
                }
            }

            foreach (var key in second.Item2.Keys)
            {
                root.Item2.TryAdd(key, second.Item2[key]);
            }
        }

        public void AddTopLeft((Node, Dictionary<CoordinatePoint, Node>) root, int idPlayFieldTil, PlayFieldTil playFieldTils)
        {
            Dictionary<double, double> reverSide = new Dictionary<double, double>()
            {
                { HelpClass.TOP_LEFT_SIDE , HelpClass.BOTTOM_RIGHT_SIDE},
                { HelpClass.TOP_LEFT_SIDE_V2 , HelpClass.BOTTOM_RIGHT_SIDE_V2 }
            };

            Connect(root, idPlayFieldTil, playFieldTils, reverSide);
        }

        public void AddTopRight((Node, Dictionary<CoordinatePoint, Node>) root, int idPlayFieldTil, PlayFieldTil playFieldTils)
        {
            Dictionary<double, double> reverSide = new Dictionary<double, double>()
            {
                { HelpClass.TOP_RIGHT_SIDE, HelpClass.BOTTOM_LEFT_SIDE},
                { HelpClass.TOP_RIGHT_SIDE_V2 , HelpClass.BOTTOM_LEFT_SIDE_V2 }
            };

            Connect(root, idPlayFieldTil, playFieldTils, reverSide);
        }

        public (Node, Dictionary<CoordinatePoint, Node>) Create(PlayFieldTil playFieldTils)
        {
            var result = new Node();
            Dictionary<CoordinatePoint, Node> keyValues = new Dictionary<CoordinatePoint, Node>();
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

            return (result, keyValues);
        }

    }
}
