namespace Ganzenbord.Business.Services
{
    public class DiceService : IDiceService
    {
        public int RollDice(int maxSides = 6)
        {
            Random random = new Random();
            return random.Next(1, maxSides + 1);
        }

        public int RollDice1()
        {
            var result = RollDice();
            return result;
        }

        public int RollDice2()
        {
            var result = RollDice();
            return result;
        }
    }
}
