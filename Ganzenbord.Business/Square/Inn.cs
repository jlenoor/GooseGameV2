using Ganzenbord.Business.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Square
{
    public class Inn : ISquare
    {
        public Inn(int skipTurns) 
        {
         SkipTurns = skipTurns;
        }
        public int SkipTurns { get; set; }
        public void HandlePlayer(IPlayer testPlayer)
        {
            testPlayer.SkipTurn(SkipTurns);
        }
    }
}
