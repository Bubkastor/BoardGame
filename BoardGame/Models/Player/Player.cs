using BoardGame.Model.Enemy;
using BoardGame.Model.Map;

namespace BoardGame.Model
{
    public class Player
    {
        public Player(CoordinatePoint position) 
        { 
            Position = position;
            HP = new HealPoint();
        }
        public Player(PlayerType playerType, SPECIAL sPECIAL){
            PlayerType = playerType;
            Special = sPECIAL;
        }

        public CoordinatePoint Position { get; set; }
        public PlayerType PlayerType { get; init; }
        public HealPoint HP { get; set; }
        public Radiation Radiation { get; set; }
        public int Caps { get; set; }
        public SPECIAL Special { get; set; }
        public Experience Exp { get; set; }
        public NpcProperties Properties { get; set; }
        public List<TraitTokenType> Peculiarities { get; set; }
        public List<Card.Card> Inventory { get; set; }
        public Card.Card EquipmentBody { get; set; }
        public Card.Card EquipmentHand { get; set; }
        public Card.Card EquipmentSatellite { get; set; }
        public Card.Card EquipmentPlans { get; set; }
    }
}
