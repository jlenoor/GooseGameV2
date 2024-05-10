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
    public class Well : ISquare
    {
        public bool IsEmpty { get; set; } = true;
        public IPlayer[] PlayerInPut { get; set; } = new IPlayer[1];

        public void HandlePlayer(IPlayer player, ILogging Logger)
        {
            if (IsEmpty)
            {
                player.ComesFromGoose = false;
                IsEmpty = false;
                PlayerInPut[0] = player;
                player.IsStuck = true;
                Logger.Log($"Profficiat, je behaalde een unieke error! Tijd om dit te break-pointen.");
            }
            else if (PlayerInPut[0].Name != player.Name) {
                player.ComesFromGoose = false;
                Logger.Log($"Op het moment dat {PlayerInPut[0].Name} zijn probleem heeft gefixed, krijg jij ook een unieke error. Tijd om dit te break-pointen.");
                PlayerInPut[0].IsStuck = false;
                Array.Clear(PlayerInPut);
                PlayerInPut[0] = player;
                player.IsStuck = true;
            }
        }
    }
}
