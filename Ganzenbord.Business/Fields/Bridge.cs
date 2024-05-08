using Ganzenbord.Business.Player;
using Ganzenbord.Business.Logger;
namespace Ganzenbord.Business.Square
{
    public class Bridge : ISquare
    {
        public Bridge(int destination)
        {
            Destination = destination;
        }
        public int Destination { get; set; }

        public void HandlePlayer(IPlayer player, ILogging Logger)
        {   
            player.MoveThroughEvents(Destination);
            Logger.Log("Je komt op een 'tab-tab'. Je gaat naar " + Destination);
        }
    }
}
