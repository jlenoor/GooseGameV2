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


        public void Move(int rolledDice, int oldPosition)
        {
            RolledValue = rolledDice;
            CurrentPosition = oldPosition + rolledDice;
        }

        public void MoveThroughEvents(int destination)
        {
            CurrentPosition = +destination;
        }
    }
}
