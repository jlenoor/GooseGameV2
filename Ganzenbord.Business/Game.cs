using Ganzenbord.Business.Factories.Interfaces;
using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Services;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business
{
    public class Game : IGame
    {
        //Dependencies declareren
        private IDiceService DiceService;
        public  ILogging logging;
        private IPlayerFactory PlayerFactory;
        private ISquareFactory SquareFactory;
        private IPlayer Player;
        private IGameLoop GameLoop;


        ISquare[] GameBoard = new ISquare[63];

        List<IPlayer> playerList = new List<IPlayer>();
        public Game (ILogging logger, ISquareFactory squareFactory, IPlayerFactory playerFactory, IPlayer player, IDiceService diceService, IGameLoop gameLoop)
        {
            this.GameLoop = gameLoop;
            this.DiceService = diceService;
            this.logging = logger;
            this.SquareFactory = squareFactory;
            this.PlayerFactory = playerFactory;
            this.Player = player;
        }
        public void StartGame()
        {

            CreateSquares(SquareFactory, GameBoard);
            CreatePlayers(playerList);
            PlayLoop(playerList, GameBoard);
            
        }

        private void PlayLoop(List<IPlayer> playerList, ISquare[] GameBoard)
        {
            while (Player.IsWinner == false) 
            {
                foreach (IPlayer player in playerList) 
                {
                    GameLoop.PlayerPlaysATurn(DiceService, player, logging, GameBoard);
                    if (player.IsWinner == true)
                    { 
                        break; 
                    }
                }  
            }
        }

        public void CreateSquares(ISquareFactory SquareFactory, ISquare[] GameBoard)
        {
            ISquare square;
            for (int i = 0; i < GameBoard.Length; i++)
            {  
                square = SquareFactory.Create(i);
                GameBoard[i] = square;
            }
        }

        public void CreatePlayers(List<IPlayer> playerList)
        {
            for (int i = 0; i < Player.PlayerNames.Length; i++)
            {
                playerList.Add(PlayerFactory.Create(Player.PlayerNames[i]));
            }
        }
    }
}
