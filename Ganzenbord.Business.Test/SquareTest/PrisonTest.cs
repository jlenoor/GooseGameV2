using Ganzenbord.Business.Logger;
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
            ILogging logger = new Logger.Logger();
            //Act
            prison.HandlePlayer(player, logger);
            //Assert
            Assert.That(skipTurns, Is.EqualTo(player.NeedsToSkip));
        }
    }
}
