using Ganzenbord.Business.Factories;
using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Test.SquareTest
{
    internal class InnTest
    {
        [Test]
        public void WhenPlayerReachesInn_ThenPlayerWaitsATurn()
        {
            //Arrange
            IPlayer player = new Player.Player("testDude");
            int waitTurns = 1;
            ISquare inN = new Inn(1);
            ILogging logger = new Logger.Logger();
            //Act
            inN.HandlePlayer(player, logger);
            //Assert
            Assert.That(waitTurns, Is.EqualTo(player.NeedsToSkip));
        }
    }
}
