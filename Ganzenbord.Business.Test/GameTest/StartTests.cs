using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Factories;
using Ganzenbord.Business.Factories.Interfaces;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;
using Moq;
using Ganzenbord.Business.Services;

namespace Ganzenbord.Business.Test.GameTest
{
    public class StartTests
    {
        [Test]
        //[Ignore("ik niet weet, is kapot, ik geef op na 5 uur")]
        public void WhenGameStarts_ThenCreateSquares()
        {
            //Arrange
            ILogging logging = new Logger.Logger();
            ISquare expectedSquare = new Normal();
            ISquare[] GameBoard = new ISquare[63];
            ISquareFactory squareFactory = new SquareFactory();
            IPlayerFactory playerFactory = new PlayerFactory();
            Mock <IPlayer> player = new Mock <IPlayer>();
            Mock <IDiceService> diceService = new Mock<IDiceService>();
            Mock <IGameLoop> gameLoop = new Mock<IGameLoop>();
            IGame game = new Game(logging,squareFactory, playerFactory,player.Object, diceService.Object, gameLoop.Object );

            //Act
            game.CreateSquares( squareFactory, GameBoard);

            //Assert
            Assert.AreEqual(GameBoard[0].GetType(), expectedSquare.GetType());
        }
        [Test]
        public void WhenGameStarts_ThenWeMakePlayers() {

            //Arrange
            ILogging logging = new Logger.Logger();
            ISquareFactory squareFactory = new SquareFactory();
            IPlayerFactory playerFactory = new PlayerFactory();
            IPlayer player = new Player.Player("Abdul");
            Mock<IDiceService> diceService = new Mock<IDiceService>();
            Mock<IGameLoop> gameLoop = new Mock<IGameLoop>();
            IGame game = new Game(logging, squareFactory, playerFactory, player, diceService.Object, gameLoop.Object);
            List<IPlayer> playerList = new List<IPlayer>();
            //Act
            game.CreatePlayers(playerList);

            //Assert
            Assert.AreEqual(playerList.First().Name, player.Name);
        }
    }
}
