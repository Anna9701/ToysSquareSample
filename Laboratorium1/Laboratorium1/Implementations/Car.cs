using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorium1.Interfaces;

namespace Laboratorium1.Implementations
{
    class Car : IAccelerate, IToy
    {
        private int speed;
        public void Accelerate(int change)
        {
            speed = change;
        }

        public int getSpeed()
        {
            return speed;
        }
    }
}
