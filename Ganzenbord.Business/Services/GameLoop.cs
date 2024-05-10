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

            if (player.FirstTurn)
            {
                logger.Log($"Je staat op Start.");
                player.FirstTurn = false;
                int roll1 = dice.RollDice();
                int roll2 = dice.RollDice();
                logger.Log($"Er wordt een {roll1} en een {roll2} gerold.");
                if (roll1 == 5 && roll2 == 4 || roll1 == 4 && roll2 == 5)
                {
                    FirstRollTeleport1(player, logger, roll1, roll2);

                }
                else if (roll1 == 6 && roll2 == 3 || roll1 == 3 && roll2 == 6)
                {
                    FirstRollTeleport2(player, logger, roll1, roll2);
                }
                else
                {
                    player.RolledValue += roll1 + roll2;
                    player.Move(player.RolledValue);
                }
            }
            else
            {
                logger.Log($"Je staat op vakje {player.CurrentPosition} .");
                if (player.NeedsToSkip > 0)
                {
                    WhenNeedsToSkip(player, logger);
                }
                else if (player.IsStuck)
                {
                    logger.Log($"Je zit nog steeds te debuggen.");
                }
                else
                {
                    WhenNormalMove(dice, player, logger);
                }
            }
            HandleSquare(player, GameBoard, logger);
            logger.NewLine();
            logger.WaitOnEnterInput();
        }

        private static void WhenNormalMove(IDiceService dice, IPlayer player, ILogging logger)
        {
            player.GoingBackwards = false;
            player.RolledValue = dice.RollDice(2);
            logger.Log($"Er wordt een {player.RolledValue} gerold.");
            player.Move(player.RolledValue);
        }

        private static void WhenNeedsToSkip(IPlayer player, ILogging logger)
        {
            logger.Log($"Je bent nog even de tijd uit het oog verloren. Dit voor nog {player.NeedsToSkip} beurten.");
            player.NeedsToSkip--;
            player.ImmuneToSkip = true;
        }

        private static void FirstRollTeleport2(IPlayer player, ILogging logger, int roll1, int roll2)
        {
            logger.Log($"Je mag direct naar vakje 53.");
            player.RolledValue += roll1 + roll2;
            player.MoveThroughEvents(53);
        }

        private static void FirstRollTeleport1(IPlayer player, ILogging logger, int roll1, int roll2)
        {
            logger.Log($"Je mag direct naar vakje 26.");
            player.RolledValue += roll1 + roll2;
            player.MoveThroughEvents(26);
        }

        public void HandleSquare(IPlayer player, ISquare[] GameBoard, ILogging logger)
        {
            logger.Log($"Je komt op vakje {player.CurrentPosition} terecht.");
            GameBoard[player.CurrentPosition].HandlePlayer(player, logger);
            while (player.ComesFromGoose)
            {
                GameBoard[player.CurrentPosition].HandlePlayer(player, logger);
            }
        }
    }
}
