
namespace BoardGame.Models.PlayerState;

public class Experience
{
    public SPECIALType CurrentType { get; init; }
    
    public Experience(SPECIALType sp)
    {
        CurrentType = sp;
    }
}
