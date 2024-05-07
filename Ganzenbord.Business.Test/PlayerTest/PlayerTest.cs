using Ganzenbord.Business.Factories;
using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Test.PlayerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenPlayerRollsDice_ThenPlayerGoesToSpecificPosition()
        {
            //Arrange
            int rolledValue = 2;
            int expectedPosition = 3;

            IPlayer playerUnderTest = new Player.Player("testName");


            //Act
            playerUnderTest.Move(rolledValue);

            //Assert
            Assert.AreEqual(playerUnderTest.CurrentPosition, expectedPosition);
        }

        [Test]
        public void WhenPlayerIsMade_ThenPlayersNameIsCorrect()
        {
            //Arrange
            string name = "testName";
            string expectedName = "testName";

            IPlayerFactory playerFactory = new PlayerFactory();

            //Act
            IPlayer player = playerFactory.Create(name);

            //Assert
            Assert.AreEqual(player.Name, expectedName);
        }
    }
}