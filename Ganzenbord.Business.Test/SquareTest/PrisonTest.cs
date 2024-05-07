using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Test.SquareTest
{
    internal class PrisonTest
    {
        [Test]
        public void WhenPlayerGetsOnPrison_ThenPlayerSkipsTurns()
        {
            //Arrange
            IPlayer player = new Player.Player("testDude");
            int skipTurns = 3;
            ISquare prison = new Prison(skipTurns);
            //Act
            prison.HandlePlayer(player);
            //Assert
            Assert.That(skipTurns, Is.EqualTo(player.NeedsToSkip));
        }
    }
}
