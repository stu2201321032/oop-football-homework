using System;

namespace oop_homework
{
    public class Game
    {
        public Team? Team1 { get; private set; }
        public Team? Team2 { get; private set; }
        public Referee? Referee1 { get; private set; }
        public Referee? Referee2 { get; private set; }
        public Referee? Referee3 { get; private set; }
        public int GoalsTeam1 { get; private set; }
        public int GoalsTeam2 { get; private set; }

        public Game(Team team1, Team team2, Referee referee1, Referee referee2, Referee referee3)
        {
            if (team1.Players?.Length != 11 && team2.Players?.Length != 11)
            {
                throw new Exception();
            }

            Team1 = team1;
            Team2 = team2;
            Referee1 = referee1;
            Referee2 = referee2;
            Referee3 = referee3;

            int chance = 10;
            int minutes = 90;

            for (int i = 0; i < minutes; i++)
            {
                int random = Random.Shared.Next(0, 91);

                if (random < chance)
                {
                    if (random <= 4)
                    {
                        GoalsTeam1++;
                        int goalScorer = Random.Shared.Next(0, 11);
                        Console.WriteLine($"{Team1.Players?[goalScorer].Name} scored a goal in minute {i}");
                    }
                    else
                    {
                        GoalsTeam2++;
                        int goalScorer = Random.Shared.Next(0, 11);
                        Console.WriteLine($"{Team1.Players?[goalScorer].Name} scored a goal in minute {i}");
                    }
                }
            }

            Console.WriteLine($"Result: {GoalsTeam1} - {GoalsTeam2}");

            if (GoalsTeam1 > GoalsTeam2)
            {
                Console.WriteLine("Winner: Team1");
            }
            else if (GoalsTeam1 < GoalsTeam2)
            {
                Console.WriteLine("Winner: Team2");
            }
            else
            {
                Console.WriteLine("Winner: Draw!");
            }
        }
    }
}
