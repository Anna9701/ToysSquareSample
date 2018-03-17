using System;
using Laboratorium1.Interfaces;
using Laboratorium1.Structs;

namespace Laboratorium1.Implementations
{
    class Car : Toy, IAccelerate
    {
        public int Speed { get; private set; }
        public override String State
        {
            get
            {
                return Name + " -> Speed: " + Speed;
            }
            protected set { }
        }

        public Car (String name, Double age, Value value) : base(age, value)

        {
            Name = name;
        }

        public void Accelerate(int change)
        {
            Speed = change;
        }

        public static IToy CreateSampleCar()
        {
            String name = "Car";
            double age = 7;
            decimal basePrice = new decimal(27876.28);
            decimal sentimentalPrice = new decimal(49765.2);
            Value value = new Value(basePrice, sentimentalPrice);
            return new Car(name, age, value);
        }
    }
}
