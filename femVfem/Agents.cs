using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace femVfem
{
    class Agents
    {
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public bool Owned { get; set; } = false;

        public Agents(string name, string type, bool owned)
        {
            Name = name;
            Type = type;
            Owned = owned;
        }
    }
}
