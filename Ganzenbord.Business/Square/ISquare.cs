using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public interface ISquare
    {
        void HandlePlayer(IPlayer testPlayer);
    }
}
