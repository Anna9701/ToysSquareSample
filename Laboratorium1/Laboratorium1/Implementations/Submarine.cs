using System;
using Laboratorium1.Interfaces;
using Laboratorium1.Structs;

namespace Laboratorium1.Implementations
{
    class Submarine : Toy, IDive
    {
        public int Depth { get; private set; }
        public override String State
        {
            get
            {
                return Name + " -> Depth: " + Depth;
            }
            protected set { }
        }

        public Submarine(String name, Double age, Value value) : base(age, value)
        {
            Name = name;
        }

        public void Dive(int change)
        {
            Depth = change;
        }

        public static IToy CreateSampleSubmarine()
        {
            String name = "Submarine";
            double age = 37;
            decimal basePrice = new decimal(2007876.28);
            decimal sentimentalPrice = new decimal(50928.2);
            Value value = new Value(basePrice, sentimentalPrice);
            return new Submarine(name, age, value);
        }
    }
}
