using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class Bridge : ISquare
    {
        public Bridge(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public void HandlePlayer(IPlayer testPlayer)
        {
            testPlayer.MoveThroughEvents(Id);
        }
    }
}
