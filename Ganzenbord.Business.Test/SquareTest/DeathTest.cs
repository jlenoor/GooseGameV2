using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Test.SquareTest
{
    internal class DeathTest
    {
        [Test]
        public void WhenPlayerGetsOnDeath_ThenPlayerGoesBackToStart()
        {
            //Arrange
            IPlayer player = new Player.Player("testDude");
            int goTo = 1;
            ISquare death = new Death(goTo);
            //Act
            death.HandlePlayer(player);
            //Assert
            Assert.That(goTo, Is.EqualTo(player.CurrentPosition));
        }
    }
}
