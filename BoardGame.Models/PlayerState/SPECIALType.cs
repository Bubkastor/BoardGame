
namespace BoardGame.Models.PlayerState;

[Flags]
public enum SPECIALType
{
    None = 0,
    S = 1,
    P = 2,
    E = 4,
    C = 8,
    I = 16,
    A = 32,
    L = 64,
}
