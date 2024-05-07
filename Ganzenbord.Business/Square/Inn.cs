using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class Inn : ISquare
    {
        public Inn(int skipTurns)
        {
            SkipTurns = skipTurns;
        }
        public int SkipTurns { get; set; }
        public void HandlePlayer(IPlayer player)
        {
            player.SkipTurn(SkipTurns);
        }
    }
}
