﻿using System;
using Laboratorium1.Interfaces;

namespace Laboratorium1.Implementations
{
    class Car : IAccelerate, IToy
    {
        public int Speed { get; private set; }
        public String Name { get; private set; }
        public String State
        {
            get
            {
                return Name + " -> Speed: " + Speed;
            }
            private set { }
        }

        public Car (String name) 
        {
            Name = name;
        }

        public void Accelerate(int change)
        {
            Speed = change;
        }
    }
}
