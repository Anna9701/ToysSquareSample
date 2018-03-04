using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorium1.Interfaces;

namespace Laboratorium1.Implementations
{
    class Plane : IRise, IToy
    {
        private int height;

        public void Rise(int change)
        {
            height = change;
        }

        public int getHeight()
        {
            return height;
        }


    }
}
