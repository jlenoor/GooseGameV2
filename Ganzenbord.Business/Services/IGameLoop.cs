using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Services
{
    public interface IGameLoop
    {
        void PlayerPlaysATurn(IDiceService dice, IPlayer player, ILogging logger, ISquare[] GameBoard);
        void HandleSquare(IPlayer player, ISquare[] GameBoard, ILogging logger);
    }
}