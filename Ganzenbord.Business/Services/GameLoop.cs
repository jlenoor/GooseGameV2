using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Square;

namespace Ganzenbord.Business.Services
{
    public class GameLoop : IGameLoop
    {
        public void PlayerPlaysATurn(IDiceService dice, IPlayer player, ILogging logger, ISquare[] GameBoard)
        {
            logger.Log($"Het is de beurt aan {player.Name}.");
            logger.Log($"Je staat op vakje {player.CurrentPosition} .");
            if (player.FirstTurn)
            {
                logger.Log($"Het is jouw eerste beurt.");
                player.FirstTurn = false;
                int roll1 = dice.RollDice();
                int roll2 = dice.RollDice();
                logger.Log($"Er wordt een {roll1} en een {roll2} gerold.");
                if (roll1 == 5 && roll2 == 4 || roll1 == 4 && roll2 == 5)
                {
                    logger.Log($"Je mag direct naar vakje 26.");
                    player.MoveThroughEvents(26);

                }
                else if (roll1 == 6 && roll2 == 3 || roll1 == 3 && roll2 == 6)
                {
                    logger.Log($"Je mag direct naar vakje 53.");
                    player.MoveThroughEvents(53);
                }
                else
                {
                    player.RolledValue = roll1 + roll2;
                    player.Move(player.RolledValue);
                }
            }
            else
            {
                if (player.NeedsToSkip < 0)
                {
                    logger.Log($"Je bent nog even de tijd uit het oog verloren. Dit voor nog {player.NeedsToSkip} beurten.");
                    player.NeedsToSkip--;
                }
                else if (player.IsStuck)
                {
                    logger.Log($"Je zit nog steeds te debuggen.");
                }
                else
                {
                    player.RolledValue += dice.RollDice(2);
                    logger.Log($"Er wordt een {player.RolledValue} gerold.");
                    player.Move(player.RolledValue);
                }
            }
            HandleSquare(player, GameBoard, logger);
            player.GoingBackwards = false;
            logger.NewLine();
            logger.WaitOnEnterInput();
        }

        private void HandleSquare(IPlayer player, ISquare[] GameBoard, ILogging logger) //deze moet kijken voor een link te maken tussen speler positie en de squares
        {
            GameBoard[player.CurrentPosition].HandlePlayer(player, logger);
        }
    }
}
