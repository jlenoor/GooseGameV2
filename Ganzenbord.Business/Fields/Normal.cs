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
              
                Logger.Log($"Je werkt rustig verder, ga naar vakje {player.CurrentPosition}.");
            }           
        }
    }
}
