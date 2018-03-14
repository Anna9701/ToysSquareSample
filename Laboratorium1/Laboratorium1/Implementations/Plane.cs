using System;
using Laboratorium1.Interfaces;
using Laboratorium1.Structs;

namespace Laboratorium1.Implementations
{
    class Plane : Toy, IRise
    {
        public int Height { get; private set; }
        public new String State
        {
            get
            {
                return Name + " -> Height: " + Height;
            }
            private set { }
        }

        public Plane(String name, Double age, Value value) : base(age, value)
        {
            Name = name;
        }

        public void Rise(int change)
        {
            Height = change;
        }

        public static IToy CreateSamplePlane()
        {
            String name = "Plane";
            double age = 3.5;
            decimal basePrice = new decimal(306572.28);
            decimal sentimentalPrice = new decimal(0);
            Value value = new Value(basePrice, sentimentalPrice);
            return new Plane(name, age, value);
        }
    }
}
