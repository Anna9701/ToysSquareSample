using System;
using Laboratorium1.Interfaces;

namespace Laboratorium1.Implementations
{
    class Computer : IToy
    {
        public String Name { get; private set; }
        public String State
        {
            get
            {
                return Name;
            }
            private set { }
        }

        public Computer(String name)
        {
            Name = name;
        }
    }
}
