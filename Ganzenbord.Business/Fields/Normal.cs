using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class Normal : ISquare
    {
        public void HandlePlayer(IPlayer player, ILogging Logger)
        {
            if (player.CurrentPosition != 53 || player.CurrentPosition != 26 || player.FirstTurn == false)
            {
                player.ComesFromGoose = false;
                Logger.Log($"Je werkt rustig verder, hier gebeurt er niets.");
            }           
        }
    }
}
