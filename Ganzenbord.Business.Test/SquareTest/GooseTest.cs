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
            player.RolledValue = 5;
            int expectedPosition = 40;
            ISquare goose = new Goose();
            //Act
            goose.HandlePlayer(player);
            //Assert
            Assert.That(expectedPosition, Is.EqualTo(player.CurrentPosition));
        }
    }
}
