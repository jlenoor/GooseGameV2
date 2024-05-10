using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Test.SquareTest
{
    internal class DeathTest
    {
        [Test]
        public void WhenPlayerGetsOnDeath_ThenPlayerGoesBackToStart()
        {
            //Arrange
            IPlayer player = new Player.Player("testDude");
            int goTo = 0;
            ISquare death = new Death(goTo);
            ILogging logger = new Logger.Logger();
            //Act
            death.HandlePlayer(player, logger);
            //Assert
            Assert.That(goTo, Is.EqualTo(player.CurrentPosition));
        }
    }
}
