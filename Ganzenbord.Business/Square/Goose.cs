using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class Goose : ISquare
    {
        public void HandlePlayer(IPlayer player)
        {
            player.Move(player.RolledValue * 2);
        }
    }
}
