using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace femVfem
{
    class Teams
    {
        private static Random rng = new Random();

        public void createTeams(List<Player> playerList)
        {
            int n = playerList.Count;
            while(n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Player value = playerList[k];
                playerList[k] = playerList[n];
                playerList[n] = value;
            }

            Console.WriteLine("Team 1: ");
            Console.WriteLine(playerList[0].Name);
            Console.WriteLine(playerList[1].Name);
            Console.WriteLine(playerList[2].Name);
            Console.WriteLine(playerList[3].Name);
            Console.WriteLine(playerList[4].Name);
            Console.WriteLine("");

            Console.WriteLine("Team 2: ");
            Console.WriteLine(playerList[5].Name);
            Console.WriteLine(playerList[6].Name);
            Console.WriteLine(playerList[7].Name);
            Console.WriteLine(playerList[8].Name);
            Console.WriteLine(playerList[9].Name);

        }


    }
}
