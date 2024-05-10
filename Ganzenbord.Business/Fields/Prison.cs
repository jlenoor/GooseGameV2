using Ganzenbord.Business.Logger;
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

        public void HandlePlayer(IPlayer player, ILogging Logger)
        {
            if (!player.ImmuneToSkip)
            {
                player.ComesFromGoose = false;
                Logger.Log($"Je hebt een 0-refference. Dit gaat even duren om op te lossen.");
                player.SkipTurn(SkipTurns);
            } 
        }
    }
}
