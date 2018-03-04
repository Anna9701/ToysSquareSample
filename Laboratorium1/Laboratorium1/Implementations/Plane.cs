using System;
using Laboratorium1.Interfaces;

namespace Laboratorium1.Implementations
{
    class Plane : IRise, IToy
    {
        public int Height { get; private set; }
        public String Name { get; private set; }

        public Plane(String name)
        {
            Name = name;
        }

        public void Rise(int change)
        {
            Height = change;
        }

        public string GetState()
        {
            return Name + " -> Height: " + Height;
        }
    }
}
