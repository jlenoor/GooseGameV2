using Ganzenbord.Business.Services;

namespace Ganzenbord.Business.Player
{
    public class Player : IPlayer
    {
        public Player(string name)
        {
            Name = name;
            CurrentPosition = 1;
        }
        public string Name { get; set; }
        public int CurrentPosition { get; set; }
        public int PreviousPosition { get; set; }
        public int RolledValue { get; set; }
        public int NeedsToSkip { get; set; }
        public bool IsStuck { get; set; }

        public void PlayerPlayATurn()
        {
            
            if (NeedsToSkip < 0) 
            {
                NeedsToSkip--;
            }
            else if (IsStuck)
            {
                GameState.NextPlayer();  
            }
            else
            {
                //Dice.Roll(2);
                Move(RolledValue, PreviousPosition);
            }
        }
        public void Move(int rolledDice, int oldPosition)
        {
            RolledValue = rolledDice;
            CurrentPosition = oldPosition + rolledDice;
        }

        public void MoveThroughEvents(int destination)
        {
            CurrentPosition += destination;
        }

        public void SkipTurn(int wait)
        {
            NeedsToSkip += wait;

        }
    }
}
