using System;

namespace oop_homework
{
    public class Team
    {
        public Coach? Coach { get; private set; }
        public Player[]? Players { get; private set; }
        public int Average { get; private set; }
        public Team(Coach coach, Player[] players)
        {
            if (players.Length < 11 || players.Length > 22)
            {
                throw new Exception();
            }

            Coach = coach;
            Players = players;

            foreach (var player in players)
            {
                Average += player.Age;
            }

            Average = Average / players.Length;
        }
    }
}
