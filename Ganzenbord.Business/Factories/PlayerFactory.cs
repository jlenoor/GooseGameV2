using Ganzenbord.Business.Factories.Interfaces;
using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        private string _name;
        public PlayerFactory()
        {
        }

        public IPlayer Create(string name)
        {
            return new Player.Player(name.ToString());
        }
    }
}
