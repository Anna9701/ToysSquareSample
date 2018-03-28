using System;
using System.Collections.Generic;
using Laboratorium1.Interfaces;



namespace Laboratorium1.Implementations
{
    class ToysSquare : IToysSquare
    {
        private ICollection<IToy> toys;

        public event EventHandler ToysNumberChanged;

        public ToysSquare() => toys = new LinkedList<IToy>();

        public int ToysNumber => toys.Count;

        public decimal AllToysValue
        {
            get
            {
                decimal sum = 0M;
                foreach (IToy toy in toys)
                {
                    sum += toy.CurrentValue;
                }
                return sum;
            }
            private set { }
        }

        public void OnToysNumberChanged(EventArgs e)
        {
            ToysNumberChanged?.Invoke(this, e);
        }

        public void AddToy(IToy toy)
        {
            toys.Add(toy);
            OnToysNumberChanged(EventArgs.Empty);
        }

        public void PrintState()
        {
            foreach (IToy toy in toys)
            {
                Console.WriteLine(toy.State);
                
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

        public void RemoveToyFromSquare (IToy toy)
        {
            toys.Remove(toy);
        }

        public void RemoveAllToysFromSquare ()
        {
            toys.Clear();
        }
    }
}
