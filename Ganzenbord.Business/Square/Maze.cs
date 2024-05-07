using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class Maze : ISquare
    {
        public Maze(int goTo)
        {
            GoTo = goTo;
        }

        public int GoTo { get; }

        public void HandlePlayer(IPlayer testPlayer)
        {
            testPlayer.MoveThroughEvents(GoTo);
        }
    }
}
