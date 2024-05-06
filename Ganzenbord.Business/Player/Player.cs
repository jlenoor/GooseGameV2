﻿using Ganzenbord.Business.Services;

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
        public bool IsStuck { get; private set; }
        public bool FirstTurn { get; set; } = true;

        public void PlayerPlayATurn(DiceService dice)
        {
            if (FirstTurn)
            {
                FirstTurn = false;
                int roll1 = dice.RollDice1();
                int roll2 = dice.RollDice2();

                if (roll1 == 5 && roll2 == 4 || roll1 == 4 && roll2 == 5)
                {
                    MoveThroughEvents(26);
                }
                else if (roll1 == 6 && roll2 == 3 || roll1 == 3 && roll2 == 6)
                {
                    MoveThroughEvents(53);
                }
                else
                {
                    int result = roll1 + roll2;
                    Move(result, PreviousPosition);
                }
            }
            else
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
                    RolledValue += dice.RollDice1() + dice.RollDice2();
                    Move(RolledValue, PreviousPosition);
                }
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
