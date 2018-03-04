using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorium1.Interfaces;

namespace Laboratorium1.Implementations
{
    class Submarine : IDive, IToy
    {
        public String Name { get; private set; }
        public int Depth { get; private set; }

        public Submarine(String name)
        {
            Name = name;
        }

        public void Dive(int change)
        {
            Depth = change;
        }

        public String GetState()
        {
            return Name + " -> Depth: " + Depth;
        }
    }
}
