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
            CurrentPosition = 1;

            PlayerNames = ["Abdul", "Bart", "Bernd", "Cedric", "Gilles", "Illya", "Jeffrey", "Robin", "Tycho"];
        }
        public string Name { get; set; }
        public int CurrentPosition { get; set; }
        public int RolledValue { get; set; }
        public int NeedsToSkip { get; set; }
        public bool FirstTurn { get; set; } = true;
        public bool IsStuck { get; set; }
        public bool IsWinner { get; set; } = false;
        public string[] PlayerNames { get; set; }
        public bool GoingBackwards { get; set; }


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
                int rest = (CurrentPosition + rolledDice); //60 rollen 12 //60 rollen 8
                rest -= 63; //9 //5
                CurrentPosition -= rest*2; //60-18 = 42 //60-10 = 50
                logger.Log("Bij het knippen en plakken ging er iets verkeerd. ");
            }
            if (CurrentPosition + rolledDice > 63)
            {
                GoingBackwards = true;
                int rest =(CurrentPosition + rolledDice) - 63;
                CurrentPosition -= rest;
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
            logger.Log($"Je bent teveel afgeleid door je computer-game. Dit duurt nog {NeedsToSkip} beurten lang.");
        }
    }
}
