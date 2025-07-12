using FluentMigrator;
using FluentMigrator.SqlServer;

namespace BoardGame.Persistence.Migrations.Migrations;

[Migration(202507110000, "Initial database structure")]
internal class _20250711_Initial: BoardGameDbMigration
{
    public override void Up()
    {
        Create.Table("GameSessions")
            .WithInt32Id("GameSessions_PK")
            .WithColumn("Code").AsString(50).NotNullable()
            .WithColumn("CreateTimeUtc").AsDateTime().WithDefaultValue(DateTime.UtcNow).NotNullable();
        
        Create.Table("Maps")
            .WithInt32Id("Maps_PK")
            .WithColumn("GameSessionId").AsInt32().NotNullable()
                .ForeignKey("Maps_GameSessionsId_FK", "GameSessions", "Id")
            .WithColumn("ScenarioType").AsInt32().NotNullable();
        
        Create.Table("Players")
            .WithInt32Id("Players_PK")
            .WithColumn("GameSessionId").AsInt32().NotNullable()
            .ForeignKey("Players_GameSessionsId_FK", "GameSessions", "Id")
            .WithColumn("Name").AsString(50).NotNullable();

    }

    public override void Down()
    {
        Delete.Table("GameSessions");
        Delete.Table("Maps");
        Delete.Table("Players");
    }
}