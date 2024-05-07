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
            //Act
            maze.HandlePlayer(player);
            //Assert
            Assert.That(goTo, Is.EqualTo(player.CurrentPosition));
        }
    }
}
