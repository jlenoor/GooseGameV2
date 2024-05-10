using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class End : ISquare
    {
        public void HandlePlayer(IPlayer player, ILogging Logger)
        {
            player.ComesFromGoose = false;
            Logger.Log("Je hebt het gehaald, je code is klaar ten koste van je mentale gezondheid.");
            player.IsWinner = true;
        }
    }
}
