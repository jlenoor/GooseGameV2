using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public interface ISquare
    {
        void HandlePlayer(IPlayer player, ILogging Logger);
    }
}
