using Ganzenbord.Business.Factories;
using Ganzenbord.Business.Factories.Interfaces;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Test.GameTest
{
    public class StartTests
    {
        [Test]
        public void WhenGameStarts_ThenCreateSquares()
        {
            //Arrange
            SquareType[] TypeBoard = new SquareType[63];
            ISquare[] GameBoard = new ISquare[63];
            ISquareFactory squareFactory = new SquareFactory();
            IGame game = new Game();

            //Act
            game.CreateSquares();

            //Assert
            Assert.AreEqual(TypeBoard[0], SquareType.Normal);
        }
    }
}
