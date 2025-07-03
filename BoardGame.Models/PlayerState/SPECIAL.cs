namespace BoardGame.Models.PlayerState;
public class SPECIAL
{
    private SPECIALType _currentSpecial;
    
    public SPECIAL(SPECIALType currentSpecial)
    {
        _currentSpecial = currentSpecial;
    }
    
    public void AddSpecial(SPECIALType currentSpecial){
        _currentSpecial = _currentSpecial | currentSpecial;
    }

    public bool HasSPECIAL(SPECIALType type)
    {
        return _currentSpecial.HasFlag(type);
    }
}