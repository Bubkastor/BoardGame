using BoardGame.Models.Enemy;

namespace BoardGame.Models;

public record DiceSide
{
    public Vulnerability Vulnerability { get; set; }
    public int Hit { get; set; }
}
