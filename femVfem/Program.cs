using System;
using System.Collections.Generic;

namespace femVfem
{
    class Program
    {
        static void Main(string[] args)
        {
            Teams teams = new Teams();
            List<Player> players = new List<Player>();
            players.Add(new Player("Thomas"));
            players.Add(new Player("Erlend"));
            players.Add(new Player("Sondre"));
            players.Add(new Player("Markus"));
            players.Add(new Player("Emil"));

            players.Add(new Player("Eivind"));
            players.Add(new Player("David"));
            players.Add(new Player("Jonathan"));
            players.Add(new Player("Martin"));
            players.Add(new Player("Mikael"));

            //CREATE TWO RANDOM TEAMS
            teams.createTeams(players);

            //Add agent & get owned agents
            Console.WriteLine();
            players[1].addAgent("REYnA");
            for (int i = 0; i < players[1].getOwnedAgents().Count; i++)
            {
                Console.WriteLine(players[1].getOwnedAgents()[i].Name);
            }




        }
    }
}
