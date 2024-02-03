namespace BoardGame.Model.Player
{
    public class Player
    {
        public PlayerType PlayerType { get; init; }
        public HealPoint HP { get; set; }
        public Radiation Radiation { get; set; }
        public int Caps { get; set; }
        public SPECIAL Special { get; set; }
        public Experience Exp { get; set; }
        public List<PeculiaritiesType> Peculiarities { get; set; }
        public List<Card.Card> Inventory { get; set; }
        public Card.Card EquipmentBody { get; set; }
        public Card.Card EquipmentHand { get; set; }
        public Card.Card EquipmentSatellite { get; set; }
        public Card.Card EquipmentPlans { get; set; }
    }
}
