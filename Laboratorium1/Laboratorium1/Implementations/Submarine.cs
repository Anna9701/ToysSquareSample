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
        private int depth;

        public void Dive(int change)
        {
            depth = change;
        }

        public int getDepth()
        {
            return depth;
        }
    }
}
