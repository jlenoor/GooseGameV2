using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Factories.Interfaces
{
    public interface ISquareFactory
    {
        ISquare Create(int fieldNumber);

    }
}
