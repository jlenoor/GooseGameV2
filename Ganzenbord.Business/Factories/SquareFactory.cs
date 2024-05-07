using Ganzenbord.Business.Factories.Interfaces;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Factories
{
    public class SquareFactory : ISquareFactory
    {
        public ISquare Create(SquareType squareType)
        {
            switch (squareType)
            {
                case SquareType.Bridge:
                    return new Bridge(12);
                case SquareType.Inn:
                    return new Inn(1);
                case SquareType.Death:
                    return new Death(1);
                case SquareType.End:
                    return new End();
                case SquareType.Maze:
                    return new Maze(39);
                case SquareType.Prison:
                    return new Prison(3);
                default:
                    return new Normal();
            }
        }

        public ISquare CreateGoose(SquareType goose)
        {
            return new Goose();
        }
    }
}