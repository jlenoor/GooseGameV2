﻿using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Square
{
    public class Death : ISquare
    {
        public Death(int goTo)
        {
            GoTo = goTo;
        }

        public int GoTo { get; }

        public void HandlePlayer(IPlayer player)
        {
            player.MoveThroughEvents(1);
        }
    }
}
