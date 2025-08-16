using BoardGame.Models.PlayerState;

namespace BoardGame.Models.View;

public class Players
{
    public List<PlayerTypeName> PlayersList { get; init; } =
    [ 
        new PlayerTypeName(PlayerType.ShelterResident, "Выходец из убежища"),
        new PlayerTypeName(PlayerType.RogueBrotherhood, "Изгой братсва"),
        new PlayerTypeName(PlayerType.Ghoul, "Гуль"),
        new PlayerTypeName(PlayerType.Supermutant, "Супермутант"),
        new PlayerTypeName(PlayerType.Wastelander, "Обитетель пустоши")
    ];
}