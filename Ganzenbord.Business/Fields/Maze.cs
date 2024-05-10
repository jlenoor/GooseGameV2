using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using System.Xml.Linq;

namespace Ganzenbord.Business.Square
{
    public class Maze : ISquare
    {
        public Maze(int goTo)
        {
            GoTo = goTo;
        }
        public int GoTo { get; }

        public void HandlePlayer(IPlayer player, ILogging Logger)
        {
            player.ComesFromGoose = false;
            Logger.Log($"Maar je moet je project opnieuw clonen, en natuurlijk ging er iets mis. Ga terug naar 39.");
            player.MoveThroughEvents(GoTo);
        }
    }
}
