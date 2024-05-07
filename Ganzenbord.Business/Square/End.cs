using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class End : ISquare
    {
        public void HandlePlayer(IPlayer player)
        {
            player.IsWinner = true;
        }
    }
}
