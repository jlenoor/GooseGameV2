using Ganzenbord.Business.Services;
using System.Numerics;
using Ganzenbord.Business.Logger;

namespace Ganzenbord.Business.Player
{
    public class Player : IPlayer
    {
        ILogging logger = new Logger.Logger();
        public Player(string name)
        {
            Name = name;
            CurrentPosition = 0;

            PlayerNames = ["Abdul"]; //, "Bart", "Bernd", "Cedric", "Gilles", "Illya", "Jeffrey", "Robin", "Tycho"];
        }
        public string Name { get; set; }
        public int CurrentPosition { get; set; }
        public int RolledValue { get; set; } = 0;
        public int NeedsToSkip { get; set; } = 0;
        public bool FirstTurn { get; set; } = true;
        public bool IsStuck { get; set; } = false;
        public bool IsWinner { get; set; } = false;
        public string[] PlayerNames { get; set; }
        public bool GoingBackwards { get; set; } = false;
        public bool ImmuneToSkip { get; set; } = false;
        public bool ComesFromGoose { get; set; } = false;

        public void Move(int rolledDice, int currentPosition)
        {
            RolledValue = rolledDice;
            CurrentPosition += rolledDice;
        }
        public void Move(int rolledDice)
        {
            RolledValue = rolledDice;
            if (GoingBackwards)
            {
                CurrentPosition -= RolledValue; //59-11 = 48 //60-10 = 50
                logger.Log("Bij het knippen en plakken ging er iets verkeerd.");
            }
            else if (CurrentPosition + rolledDice > 63)
            {
                GoingBackwards = true;
                int rest =(CurrentPosition + rolledDice) - 63;
                CurrentPosition = 63 - rest;
                logger.Log("Je dacht dat je bijna klaar was, maar bent vergeten opslaan. Ga terug naar " + CurrentPosition);
            }
            else
            {
                CurrentPosition += rolledDice;
            }
        }
        public void MoveThroughEvents(int destination)
        {
            CurrentPosition = destination;
            
        }
        public void SkipTurn(int wait)
        {
            NeedsToSkip += wait;
            logger.Log($"Je bent nog steeds bezig. Dit duurt nog {NeedsToSkip} beurten lang.");
        }
    }
}
