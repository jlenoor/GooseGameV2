using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Fields
{
    public class Start : ISquare
    {
        public void HandlePlayer(IPlayer player, ILogging Logger)
        {
            Logger.Log("Je bent van het veld gesmeten. Tijd om opnieuw een first turn te krijgen.");
            player.FirstTurn = true;
        }
    }
}
