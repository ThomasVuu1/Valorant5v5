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
        public List<Agent> agents = new List<Agent>();

        public Player(string user)
        {
            this.Name = user;
            getAgents();
        }

        public void getAgents()
        {
            agents.Add(new Agent("Brimstone", "Controller", true));
            agents.Add(new Agent("Phoenix", "Duelist", true));
            agents.Add(new Agent("Sage", "Sentinel", true));
            agents.Add(new Agent("Sova", "Initiator", true));
            agents.Add(new Agent("Jett", "Duelist", true));
            agents.Add(new Agent("Viper", "Controller", false));
            agents.Add(new Agent("Cypher", "Sentinel", false));
            agents.Add(new Agent("Reyna", "Duelist", false));
            agents.Add(new Agent("Killjoy", "Sentinel", false));
            agents.Add(new Agent("Breach", "Initiator", false));
            agents.Add(new Agent("Omen", "Controller", false));
            agents.Add(new Agent("Raze", "Duelist", false));
            agents.Add(new Agent("Skye", "Initiator", false));
            agents.Add(new Agent("Yoru", "Duelist", false));
            agents.Add(new Agent("Astra", "Controller", false));
        }

        public List<Agent> getOwnedAgents()
        {
            List<Agent> ownedAgents = new List<Agent>();
            foreach(Agent a in agents)
            {
                if(a.Owned == true)
                {
                    ownedAgents.Add(a);
                }
            }
            return ownedAgents;
        }

        public void addAgent(string agentName)
        {
            int i = agents.FindIndex(a => a.Name == agentName);
            agents[i].Owned = true;
        }
       

    }

}