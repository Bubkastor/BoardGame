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
        public void AddRight((Node, Dictionary<CoordinatePoint, Node>) left, PlayFieldTil playFieldTils)
        {
            var right = Create(playFieldTils);
            var nodeWithRightSideConnectTop = new List<Node>();
            foreach (var key in left.Item2.Keys)
            {
                if (left.Item2[key].Side.Contains(HelpClass.RIGHT_SIDE))
                {
                    nodeWithRightSideConnectTop.Add(left.Item2[key]);
                    left.Item2[key].Side.RemoveAll(x => x == HelpClass.RIGHT_SIDE);
                }
            };
            var nodeWithRightSideConnectBottom = new List<Node>();
            foreach (var key in left.Item2.Keys)
            {
                if (left.Item2[key].Side.Contains(HelpClass.RIGHT_SIDE_V2))
                {
                    nodeWithRightSideConnectBottom.Add(left.Item2[key]);
                    left.Item2[key].Side.RemoveAll(x => x == HelpClass.RIGHT_SIDE_V2);
                }
            };

            foreach (var key in right.Item2.Keys)
            {
                var leftSideNodeConnect = right.Item2[key];
                if (leftSideNodeConnect.Side.Contains(HelpClass.LEFT_SIDE))
                {
                    leftSideNodeConnect.Neighbors.AddRange(nodeWithRightSideConnectTop);
                    foreach(var node in nodeWithRightSideConnectTop)
                    {
                        node.Neighbors.Add(leftSideNodeConnect);
                    }
                    leftSideNodeConnect.Side.RemoveAll(x => x == HelpClass.LEFT_SIDE);
                }
                if (leftSideNodeConnect.Side.Contains(HelpClass.LEFT_SIDE_V2))
                {
                    leftSideNodeConnect.Neighbors.AddRange(nodeWithRightSideConnectBottom);
                    foreach (var node in nodeWithRightSideConnectBottom)
                    {
                        node.Neighbors.Add(leftSideNodeConnect);
                    }
                    leftSideNodeConnect.Side.RemoveAll(x => x == HelpClass.LEFT_SIDE_V2);
                }
            }
            foreach (var key in right.Item2.Keys)
            {
                left.Item2.TryAdd(key, right.Item2[key]);
            }
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
