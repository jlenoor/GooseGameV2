using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class Prison : ISquare
    {
        public Prison(int skipTurns)
        {
            SkipTurns = skipTurns;
        }

        public int SkipTurns { get; }

        public void HandlePlayer(IPlayer player)
        {
            player.SkipTurn(SkipTurns);
        }
    }
}
