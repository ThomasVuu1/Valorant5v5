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
            agents.Add(new Agent("BRIMSTONE","Brimstone", "Controller", true));
            agents.Add(new Agent("PHOENIX","Phoenix", "Duelist", true));
            agents.Add(new Agent("SAGE","Sage", "Sentinel", true));
            agents.Add(new Agent("SOVA","Sova", "Initiator", true));
            agents.Add(new Agent("JETT","Jett", "Duelist", true));
            agents.Add(new Agent("VIPER","Viper", "Controller", false));
            agents.Add(new Agent("CHYPER","Cypher", "Sentinel", false));
            agents.Add(new Agent("REYNA","Reyna", "Duelist", false));
            agents.Add(new Agent("KILLJOY","Killjoy", "Sentinel", false));
            agents.Add(new Agent("BREACH","Breach", "Initiator", false));
            agents.Add(new Agent("OMEN","Omen", "Controller", false));
            agents.Add(new Agent("RAZE","Raze", "Duelist", false));
            agents.Add(new Agent("SKYE","Skye", "Initiator", false));
            agents.Add(new Agent("YORU","Yoru", "Duelist", false));
            agents.Add(new Agent("ASTRA","Astra", "Controller", false));
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

        public void addAgent(string agentId)
        {
            agentId = agentId.ToUpper();
            int i = agents.FindIndex(a => a.Id == agentId);
            agents[i].Owned = true;
        }
       

    }

}