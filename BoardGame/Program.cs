// See https://aka.ms/new-console-template for more information
using BoardGame.Builder;
using BoardGame.Repository;

Console.WriteLine("Hello, World!");
BuildNodeGraph builder = new BuildNodeGraph();

PlayFieldTilRepository playFieldTilRepository = new PlayFieldTilRepository();
var til = playFieldTilRepository.GetPlayFieldTilById(1);
var til2 = playFieldTilRepository.GetPlayFieldTilById(2);
var node = builder.Create(til);
builder.AddRight(node, til2);
Console.WriteLine(node);