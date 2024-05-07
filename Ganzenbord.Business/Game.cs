using Castle.Core.Logging;
using Ganzenbord.Business.Factories.Interfaces;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Services;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business
{
    public class Game : IGame
    {
        //Dependencies declareren
        private IDiceService DiceService;
        private ILogger Logger;
        private IPlayerFactory PlayerFactory;
        private ISquareFactory SquareFactory;
        private IPlayer player;

        SquareType[] TypeBoard = new SquareType[63];
        ISquare[] GameBoard = new ISquare[63];

        List<IPlayer> playerList = new List<IPlayer>();

        public void StartGame()
        {

        }

        public void CreateSquares()
        {
            for (int i = 0; i < TypeBoard.Length; i++)
            {
                if (i / 5 == 0 || i / 9 == 0 || i == 14 || i == 23 || i == 41 || i == 59) //TODO: Refactor
                {
                    GameBoard[i] = SquareFactory.CreateGoose(TypeBoard[i]);
                }
                else
                {
                    GameBoard[i] = SquareFactory.Create((SquareType)TypeBoard[i]);
                }

                if (GameBoard[i] == null)
                {
                    GameBoard[i] = new Normal();
                }
            }
        }

        public void CreatePlayers()
        {
            for (int i = 0; i <= player.PlayerNames.Length; i++)
            {
                playerList.Add(PlayerFactory.Create(player.PlayerNames[i]));
            }
        }
    }
}
