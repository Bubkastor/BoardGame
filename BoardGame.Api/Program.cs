using BoardGame.Application;
using BoardGame.Models;
using BoardGame.Persistence;
using BoardGame.Persistence.Migrations;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddModelsDependencies();
builder.Services.AddApplicationDependencies();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "BoardGame API",
        Description = "Api for testing"
    });
});
builder.Services.ConfigureBoardGameDb(builder.Configuration.GetSection("Persistence:BoardGameDb"));

var app = builder.Build();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}
else
{
    app.UseHttpsRedirection();
}

app.UpdateBoardGameDb(builder.Configuration.GetSection("Persistence:BoardGameDb"));
app.UseSwagger();
app.UseSwaggerUI();

app.Run();