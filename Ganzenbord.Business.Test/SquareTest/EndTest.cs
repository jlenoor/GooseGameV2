using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Test.SquareTest
{
    internal class EndTest
    {
        [Test]
        public void WhenPlayerGetsOnEnd_ThenPlayerWinsTheGame()
        {
            //Arrange
            IPlayer player = new Player.Player("testDude");
            ISquare end = new End();
            ILogging logger = new Logger.Logger();
            //Act
            end.HandlePlayer(player, logger);
            //Assert
            Assert.IsTrue(player.IsWinner);
        }
    }
}
