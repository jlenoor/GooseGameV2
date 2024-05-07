namespace Ganzenbord.Business.Services
{
    public interface IDiceService
    {
        int RollDice(int maxSides = 6);
        int RollDice();
    }
}