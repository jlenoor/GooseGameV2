using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Factories.Interfaces
{
    public interface ISquareFactory
    {
        ISquare Create(SquareType squareType);
        ISquare CreateGoose(SquareType squareType);
    }
}
