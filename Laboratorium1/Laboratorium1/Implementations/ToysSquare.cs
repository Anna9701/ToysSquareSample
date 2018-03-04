using System;
using System.Collections.Generic;
using Laboratorium1.Interfaces;

namespace Laboratorium1.Implementations
{
    class ToysSquare : IToysSquare
    {
        private ICollection<IToy> toys;

        public ToysSquare() => toys = new LinkedList<IToy>();

        public void AddToy(IToy toy)
        {
            toys.Add(toy);
        }

        public void PrintState()
        {
            foreach(IToy toy in toys)
            {
                Console.WriteLine(toy.GetState());
            }
        }

        public void ChangeDepth(int change)
        {
            foreach (IToy toy in toys)
            {
                if (toy is IDive t)
                {
                    t.Dive(change);
                }
            }
        }

        public void ChangeHeight(int change)
        {
            foreach (IToy toy in toys)
            {
                if (toy is IRise t)
                {
                    t.Rise(change);
                }
            }
        }

        public void ChangeSpeed(int change)
        {
            foreach (IToy toy in toys)
            {
                if (toy is IAccelerate t)
                {
                    t.Accelerate(change);
                }
            }
        }
    }
}
