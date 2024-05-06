using Ganzenbord.Business.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Square
{
    internal class Inn : ISquare
    {
        public void HandlePlayer(IPlayer testPlayer)
        {
            testPlayer.SkipTurn(1);
        }
    }
}
