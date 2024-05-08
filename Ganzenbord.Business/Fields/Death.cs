using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class Death : ISquare
    {
        public Death(int goTo)
        {
            GoTo = goTo;
        }
        public int GoTo { get; }

        public void HandlePlayer(IPlayer player, ILogging Logger)
        {   
            Logger.Log("Jouw GitHub doet weer raar. Alles is weg. Begin opnieuw.");
            player.MoveThroughEvents(1);   
        }
    }
}
