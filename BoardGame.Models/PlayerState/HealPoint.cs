
namespace BoardGame.Models.PlayerState;
public record HealPoint
{
    public HealPoint()
    {
        MaxHP = 16;
        CurrentHp = 16;
    }

    public int MaxHP { get; init; }
    public int CurrentHp { get; set; }
}
