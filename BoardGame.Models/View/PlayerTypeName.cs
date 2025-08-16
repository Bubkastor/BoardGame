using BoardGame.Models.PlayerState;

namespace BoardGame.Models.View;

public record PlayerTypeName(PlayerType player, string namePlayerType)
{
    public int Id
    {
        get => (int)Player;
    }
    public PlayerType Player { get; init; } = player;
    public string NamePlayerType { get; init; } = namePlayerType;
    public override string ToString()
    {
        return NamePlayerType;
    }
}