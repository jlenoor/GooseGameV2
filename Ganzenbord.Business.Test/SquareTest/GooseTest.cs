using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Test.SquareTest
{
    internal class GooseTest
    {
        [Test]
        public void WhenPlayerGetsOnGoose_ThenPlayerMovesDoubleTheSquares()
        {
            //Arrange
            IPlayer player = new Player.Player("testDude");
            player.CurrentPosition = 30;
            player.RolledValue = 6;
            int expectedPosition = 36;
            ISquare goose = new Goose();
            ILogging logger = new Logger.Logger();
            //Act
            goose.HandlePlayer(player, logger);
            //Assert
            Assert.That(expectedPosition, Is.EqualTo(player.CurrentPosition));
        }
    }
}
