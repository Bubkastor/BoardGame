namespace BoardGame.Models.PlayerState;

public static class StartPlayer
{
    public static Player Ghul()
    {
        return new Player(PlayerType.Ghoul, new SPECIAL(SPECIALType.P));
    }

    public static Player ShelterResident()
    {
        return new Player(PlayerType.ShelterResident, new SPECIAL(SPECIALType.L));
    }

    public static Player RogueBrotherhood()
    {
        return new Player(PlayerType.RogueBrotherhood, new SPECIAL(SPECIALType.I));
    }

    public static Player Supermutant()
    {
        return new Player(PlayerType.Supermutant, new SPECIAL(SPECIALType.S));
    }

    public static Player Wastelander()
    {
        return new Player(PlayerType.Wastelander, new SPECIAL(SPECIALType.A));
    }
}
