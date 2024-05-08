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
            Logger.Log($"Je moet je project opnieuw clonen, er ging iets mis.");
            player.MoveThroughEvents(GoTo);
        }
    }
}
