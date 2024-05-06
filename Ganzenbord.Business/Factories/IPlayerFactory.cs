using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Factories
{
    public interface IPlayerFactory
    {
        IPlayer Create(string name);
    }
}