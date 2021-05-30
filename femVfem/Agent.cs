using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace femVfem
{
    class Agent
    {
        public string Id { get; set; }
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public bool Owned { get; set; } = false;

        public Agent(string id, string name, string type, bool owned)
        {
            Id = id;
            Name = name;
            Type = type;
            Owned = owned;
        }
    }
}
