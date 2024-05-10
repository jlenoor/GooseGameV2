using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Services;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Test.GameLoopTests
{
    internal class GameLoopTests
    {


        [Test]
        [Ignore("Deze krijgen we niet aan het werk")]
        public void WhenPlayerGetsOnGooseFromGooseGoingBackwards_ThenHeKeepsGoingBackwards()
        {
            //Arrange
            IPlayer player = new Player.Player("testDude");
            player.CurrentPosition = 59;
            player.RolledValue = 5;
            int expectedPosition1 = 49;
            ISquare[] GameBoard = new ISquare[64];
            GameBoard[59] = new Goose();
            GameBoard[54] = new Goose();
            GameBoard[49] = new Normal();
            ILogging logger = new Logger.Logger();
            IGameLoop gameLoop = new GameLoop();
            
            //Act

            gameLoop.HandleSquare(player, GameBoard, logger);

            //Assert
            Assert.That(expectedPosition1, Is.EqualTo(player.CurrentPosition));
        }
    }
}
