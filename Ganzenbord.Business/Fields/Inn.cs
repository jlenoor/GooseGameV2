using Ganzenbord.Business.Logger;
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
        public void HandlePlayer(IPlayer player, ILogging Logger)
        {
            if (!player.ImmuneToSkip)
            {
                player.ComesFromGoose = false;
                Logger.Log($"Je gaat vlug een beurtje computer-spelletjes spelen.");
                player.SkipTurn(SkipTurns);
            }
        }
    }
}
