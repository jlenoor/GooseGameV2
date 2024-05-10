using Ganzenbord.Business.Factories.Interfaces;
using Ganzenbord.Business.Fields;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Factories
{
    public class SquareFactory : ISquareFactory
    {
        public ISquare Create(int fieldNumber)
        {
            switch (fieldNumber)
            {
                case 0:
                    return new Start();
                case 6:
                    return new Bridge(12);
                case 19:
                    return new Inn(1);
                case 31:
                    return new Well();
                case 42:
                    return new Maze(39);
                case 52:
                    return new Prison(3);
                case 58:
                    return new Death(1);
                case 63:
                    return new End();
                case 5:
                case 9:
                case 14:
                case 18:
                case 23:
                case 27:
                case 32:
                case 36:
                case 41:
                case 45:
                case 50:
                case 54:
                case 59:
                    return new Goose();
                default:
                    return new Normal();
            }
        }
    }
}