using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class Bridge : ISquare
    {
        public Bridge(int v)
        {
            V = v;
        }

        public int V { get; }

        public void HandlePlayer(IPlayer testPlayer)
        {
            testPlayer.MoveThroughEvents(12);
        }
    }
}
