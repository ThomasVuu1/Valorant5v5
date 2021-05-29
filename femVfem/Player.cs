using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace femVfem
{
    class Player
    {
        public string Name { get; set; }
        public List<Agents> agents = new List<Agents>();

        public Player(string user)
        {
            this.Name = user;
            getAgents();
        }

        public void getAgents()
        {
            agents.Add(new Agents("Brimstone", "Controller", true));
            agents.Add(new Agents("Phoenix", "Duelist", true));
            agents.Add(new Agents("Sage", "Sentinel", true));
            agents.Add(new Agents("Sova", "Initiator", true));
            agents.Add(new Agents("Jett", "Duelist", true));
            agents.Add(new Agents("Viper", "Controller", false));
            agents.Add(new Agents("Cypher", "Sentinel", false));
            agents.Add(new Agents("Reyna", "Duelist", false));
            agents.Add(new Agents("Killjoy", "Sentinel", false));
            agents.Add(new Agents("Breach", "Initiator", false));
            agents.Add(new Agents("Omen", "Controller", false));
            agents.Add(new Agents("Raze", "Duelist", false));
            agents.Add(new Agents("Skye", "Initiator", false));
            agents.Add(new Agents("Yoru", "Duelist", false));
            agents.Add(new Agents("Astra", "Controller", false));
        }

        public List<Agents> getOwnedAgents()
        {
            List<Agents> ownedAgents = new List<Agents>();
            foreach(Agents a in agents)
            {
                if(a.Owned == true)
                {
                    ownedAgents.Add(a);
                }
            }
            return ownedAgents;
        }
       

    }

}