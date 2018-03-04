using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorium1.Interfaces;

namespace Laboratorium1.Implementations
{
    class ToysSquare : IToysSquare
    {
        private LinkedList<IToy> toys;

        public ToysSquare()
        {
            toys = new LinkedList<IToy>();
        }

        public void addToy(IToy toy)
        {
            toys.AddLast(toy);
        }

        public void getState()
        {
            foreach(IToy toy in toys)
            {
                if (toy is IAccelerate)
                {
                    IAccelerate t = (IAccelerate)toy;
                    Console.Out.WriteLine("Speed: {0}", t.getSpeed());
                } else if (toy is IDive)
                {
                    IDive t = (IDive)toy;
                    Console.Out.WriteLine("Depth: {0}", t.getDepth());
                } else if (toy is IRise)
                {
                    IRise t = (IRise)toy;
                    Console.Out.WriteLine("Speed: {0}", t.getHeight());
                }
            }
        }
        public void changeDepth(int change)
        {
            foreach (IToy toy in toys)
            {
                if (toy is IDive)
                {
                    IDive t = (IDive)toy;
                    t.Dive(change);
                }
            }
        }

        public void changeHeight(int change)
        {
            foreach (IToy toy in toys)
            {
                if (toy is IRise)
                {
                    IRise t = (IRise)toy;
                    t.Rise(change);
                }
            }
        }

        public void changeSpeed(int change)
        {
            foreach (IToy toy in toys)
            {
                if (toy is IAccelerate)
                {
                    IAccelerate t = (IAccelerate)toy;
                    t.Accelerate(change);
                }
            }
        }
    }
}
