// See https://aka.ms/new-console-template for more information
using BoardGame.Builder;
using BoardGame.Model.Map;
using BoardGame.Repository;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using System.Windows.Media;

Console.WriteLine("Hello, World!");
BuildNodeGraph builder = new BuildNodeGraph();

//fill map
PlayFieldTilRepository playFieldTilRepository = new PlayFieldTilRepository();
var til = playFieldTilRepository.GetPlayFieldTilById(1);
var til2 = playFieldTilRepository.GetPlayFieldTilById(2);
var node = builder.Create(til);
builder.AddBottomLeft(node, 1, til2);

//show View
Form form = new Form();
GViewer viewer = new GViewer();
Graph graph = new Graph("map");

Dictionary<CoordinatePoint, bool> isAddedCoordinatePoint = new Dictionary<CoordinatePoint, bool>();

AddGraph(node.Item2, graph);



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