using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class Goose : ISquare
    {
        public void HandlePlayer(IPlayer player, ILogging Logger)
        {
            Logger.Log($"Je vind een stukje code op StackOverflow. Je control-C, control-V een stukje.");
            player.Move(player.RolledValue);
            Logger.Log($"Je komt daardoor op vakje {player.CurrentPosition}.");
        }
    }
}
