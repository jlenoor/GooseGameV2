namespace Ganzenbord.Business.Player
{
    public interface IPlayer
    {
        int CurrentPosition { get; set; }
        string Name { get; set; }
        int RolledValue { get; set; }
        public int NeedsToSkip { get; set; }
        public bool IsStuck { get; set; }
        public bool IsWinner { get; set; }
        public string[] PlayerNames { get; set; }

        void Move(int rolledDice);
        void Move(int rolledDice, int currentPosition);
        void MoveThroughEvents(int destination);
        void SkipTurn(int wait);
    }
}