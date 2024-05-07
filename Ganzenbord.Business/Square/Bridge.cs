using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class Bridge : ISquare
    {
        public Bridge(int destination)
        {
            Id = destination;
        }

        public int Id { get; set; }

        public void HandlePlayer(IPlayer player)
        {
            player.MoveThroughEvents(Id);
        }
    }
}
