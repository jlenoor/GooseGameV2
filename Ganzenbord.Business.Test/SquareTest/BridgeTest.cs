using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Test.SquareTest
{
    internal class BridgeTest
    {
        [Test]
        public void WhenPlayerLandsOnBridge_ThenPlayerIsMovedToTwelved()
        {
            //Arrange
            IPlayer testPlayer = new Player.Player("testName"); //TODO: Factory
            ISquare bridge = new Bridge(12);
            ILogging logger = new Logger.Logger();

            //Act
            bridge.HandlePlayer(testPlayer, logger);

            //Assert
            Assert.That(12, Is.EqualTo(testPlayer.CurrentPosition));
        }
    }
}
