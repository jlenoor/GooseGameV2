namespace Ganzenbord.Business.Player
{
    public interface IPlayer
    {
        int CurrentPosition { get; set; }
        public int PreviousPosition { get; set; }
        string Name { get; set; }
        int RolledValue { get; set; }

        void Move(int rolledDice, int oldPosition);
        void MoveThroughEvents(int destination);
        void SkipTurn(int wait);
    }
}