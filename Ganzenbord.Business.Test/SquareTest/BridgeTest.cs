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
            ISquare bridge = new Bridge(6);

            //Act
            bridge.HandlePlayer(testPlayer);

            //Assert
            Assert.That(12, Is.EqualTo(testPlayer.CurrentPosition));
            Assert.That(6, Is.EqualTo(testPlayer.PreviousPosition));
        }
    }
}
