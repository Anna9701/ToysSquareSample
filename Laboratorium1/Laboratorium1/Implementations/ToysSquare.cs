using System;
using System.Collections.Generic;
using Laboratorium1.Interfaces;

namespace Laboratorium1.Implementations
{
    class ToysSquare : IToysSquare
    {
        private ICollection<IToy> toys;

        public static decimal MAXIMUM_VALUE => 500000.50M;

        public event EventHandler ToysNumberChanged;

        public ToysSquare() => toys = new LinkedList<IToy>();

        public int ToysNumber => toys.Count;

        public void OnChanged(EventArgs e)
        {
            ToysNumberChanged?.Invoke(this, e);
        }

        public void AddToy(IToy toy)
        {
            toys.Add(toy);
            toy.ValueChanged += Toy_ValueChanged;
            OnChanged(EventArgs.Empty);
        }


        private void Toy_ValueChanged(object sender, EventArgs e)
        {
            decimal sum = 0M;
            foreach (IToy toy in toys)
            {
                sum += toy.CurrentValue;
            }
            if (sum > MAXIMUM_VALUE)
            {
                Console.WriteLine("The value of toys in square is too large! Aborting...");
                throw new ApplicationException();
            }
        }

        public void PrintState()
        {
            foreach (IToy toy in toys)
            {
                if (toy is IAccelerate t)
                {
                    Console.WriteLine(t.State);
                }
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
