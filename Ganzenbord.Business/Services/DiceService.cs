namespace Ganzenbord.Business.Services
{
    public class DiceService : IDiceService
    {
        public int RollDice(int amountDice)
        {
            Random random = new Random();

            int result = 0;

            for (int i = 0; amountDice > i; i++)
            {
                result += random.Next(1, 7);
            }

            return result;
        }

        public int RollDice()
        {
            Random random = new Random();
            var result = random.Next(1, 7);

            return result;
        }
    }
}
