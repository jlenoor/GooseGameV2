using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Test.SquareTest
{
    internal class MazeTest
    {
        [Test]
        public void WhenPlayerGetsOnMaze_ThenPlayerMovesToQsuare39()
        {
            //Arrange
            IPlayer player = new Player.Player("testDude");
            int goTo = 39;
            ISquare maze = new Maze(goTo);
            ILogging logger = new Logger.Logger();
            //Act
            maze.HandlePlayer(player, logger);
            //Assert
            Assert.That(goTo, Is.EqualTo(player.CurrentPosition));
        }
    }
}
