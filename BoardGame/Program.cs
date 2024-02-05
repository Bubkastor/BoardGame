// See https://aka.ms/new-console-template for more information
using BoardGame.Builder;
using BoardGame.Game.Fight;
using BoardGame.Game.Scenario;
using BoardGame.Model.Enemy;
using BoardGame.Model.Map;
using BoardGame.Model.Player;
using BoardGame.Model.Tiles;
using BoardGame.Models.Map;
using BoardGame.Repository;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using System.Windows.Media;

BuildNodeGraph builder = new BuildNodeGraph();

//fill map
PlayFieldTilRepository playFieldTilRepository = new PlayFieldTilRepository();

//Map map =;
StartScenario startScenario = new StartScenario();

//for (int i = 0; i < startScenario.Map.Rank; i++)
//{
//    for (int j = 0; j < startScenario.Map.GetLength(i); j++)
//    {
//        var cell = startScenario.Map[i, j];
//        if(cell.IdTil != 0)
//        {
//            var til = playFieldTilRepository.GetPlayFieldTilById(cell.IdTil);
//        }
//    }
//}

var position = new CoordinatePoint(0, 0);

INpcRepository npcRepository = new NpcRepository();

Npc npc = npcRepository.GetEnymyByKind(BoardGame.Model.NpcType.Creature);
npc.Position = new CoordinatePoint(0, 0);

var player = new Player(position);
Fight fight = new Fight();

var isWinFight = fight.IsWinFight(player, npc);
Console.WriteLine(npc.ToString());
Console.WriteLine($"Fight is win?: {isWinFight}");
Console.WriteLine($"Player HP: {player.HP.CurrentHp}");



var til = playFieldTilRepository.GetPlayFieldTilById(14);
var til2 = playFieldTilRepository.GetPlayFieldTilById(2);
var til3 = playFieldTilRepository.GetPlayFieldTilById(3);
til2.Visible = true;
til3.Visible = true;
var node = builder.Create(til);
builder.AddRight(node, til.Id, til2);
builder.AddRight(node, til2.Id, til3);


//show View
Form form = new Form();
GViewer viewer = new GViewer();
Graph graph = new Graph("map");

Dictionary<CoordinatePoint, bool> isAddedCoordinatePoint = new Dictionary<CoordinatePoint, bool>();

AddGraph(node.NodeList, graph);


viewer.Graph = graph;
form.SuspendLayout();
viewer.Dock = DockStyle.Fill;
form.Controls.Add(viewer);
form.ResumeLayout();
///show the form
///
form.ShowDialog();

void AddGraph(Dictionary<CoordinatePoint, BoardGame.Model.Map.Node> coordNodeMap, Graph graph)
{
    HashSet<(string, string)> existPath = new HashSet<(string, string)>();
    foreach (var key in coordNodeMap.Keys)
    {
        var node = coordNodeMap[key];

        graph.AddNode(key.ToString());
        foreach (var neig in node.Neighbors)
        {
            if (!existPath.Contains((key.ToString(), neig.Coordinate.ToString())))
            {
                graph.AddEdge(key.ToString(), neig.Coordinate.ToString());
                existPath.Add((key.ToString(), neig.Coordinate.ToString()));

            }

            if (!existPath.Contains((neig.Coordinate.ToString(), key.ToString())))
            {
                graph.AddEdge(neig.Coordinate.ToString(), key.ToString());
                existPath.Add((neig.Coordinate.ToString(), key.ToString()));
            }

            if (node.DifficultyAreaType == BoardGame.Model.DifficultyAreaType.Crossed)
            {
                graph.FindNode(key.ToString()).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
            }

            if (node.DifficultyAreaType == BoardGame.Model.DifficultyAreaType.Radiation)
            {
                graph.FindNode(key.ToString()).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
            }
        }

    }
}