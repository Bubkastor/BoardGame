using BoardGame.Models.Enemy;

namespace BoardGame.Models;

public class Dice
{
    public DiceSide Roll { get
        {
            var i = random.Next(0, 5);
            DiceSide diceSide;
            switch (i)
            {
                case 0:
                    diceSide = new DiceSide()
                    {
                        Hit = 0,
                        Vulnerability = Vulnerability.Body
                    };
                    break;

                case 1:
                    diceSide = new DiceSide()
                    {
                        Hit = 1,
                        Vulnerability = Vulnerability.Head
                    };
                    break;

                case 2:
                    diceSide = new DiceSide()
                    {
                        Hit = 1,
                        Vulnerability = Vulnerability.Body
                    };
                    break;

                case 3:
                    diceSide = new DiceSide()
                    {
                        Hit = 1,
                        Vulnerability = Vulnerability.Hands
                    };
                    break;

                case 4:
                    diceSide = new DiceSide()
                    {
                        Hit = 2,
                        Vulnerability = Vulnerability.Legs | Vulnerability.Body | Vulnerability.Hands,
                    };
                    break;

                default:
                    diceSide = new DiceSide()
                    {
                        Hit = 0,
                        Vulnerability = Vulnerability.Legs
                    };
                    break;
            }
            Console.WriteLine($"Dice Roll: {diceSide}");
            return diceSide;
        }
    }
    private Random random;
    public Dice()
    {
            random = new Random();
    }

}
