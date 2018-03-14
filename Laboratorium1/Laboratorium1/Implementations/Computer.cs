using System;
using Laboratorium1.Interfaces;
using Laboratorium1.Structs;

namespace Laboratorium1.Implementations
{
    class Computer : Toy
    {
        public Computer(String name, Double age, Value value) : base(age, value)
        {
            Name = name;
        }

        public static IToy CreateSampleComputer()
        {
            String name = "Computer";
            double age = 0.5;
            decimal basePrice = new decimal(7500);
            decimal sentimentalPrice = new decimal(1000);
            Value value = new Value(basePrice, sentimentalPrice);
            return new Computer(name, age, value);
        }
    }
}
