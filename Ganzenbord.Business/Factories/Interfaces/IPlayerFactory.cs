using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Factories.Interfaces
{
    public interface IPlayerFactory
    {
        IPlayer Create(string name);
    }
}