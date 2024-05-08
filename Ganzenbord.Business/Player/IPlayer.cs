namespace Ganzenbord.Business.Player
{
    public interface IPlayer
    {
        int CurrentPosition { get; set; }
        string Name { get; set; }
        int RolledValue { get; set; }
        int NeedsToSkip { get; set; }
        bool IsStuck { get; set; }
        bool IsWinner { get; set; }
        string[] PlayerNames { get; set; }
        bool FirstTurn { get; set; }
        bool GoingBackwards { get; set; }
        void Move(int rolledDice);
        void Move(int rolledDice, int currentPosition);
        void MoveThroughEvents(int destination);
        void SkipTurn(int wait);
    }
}