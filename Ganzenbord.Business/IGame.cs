﻿using Ganzenbord.Business.Factories.Interfaces;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business
{
    public interface IGame
    {
        int GameTurn { get; set;  }
        void CreatePlayers(List<IPlayer> playerList);
        void CreateSquares(ISquareFactory SquareFactory, ISquare[] GameBoard);
        void StartGame();
    }
}