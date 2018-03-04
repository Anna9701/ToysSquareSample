using System;
using Laboratorium1.Implementations;
using Laboratorium1.Interfaces;

namespace Laboratorium1
{
    class Program
    {
        static void Main(string[] args)
        {
            InitSquare();
            Console.ReadKey();
        }

        static private void InitSquare()
        {
            IToy car = new Car("Car");
            IToy plane = new Plane("Plane");
            IToy submarine = new Submarine("Submarine");
            IToy compuer = new Computer("Computer");
            IToysSquare square = new ToysSquare();

            square.AddToy(car);
            square.AddToy(plane);
            square.AddToy(submarine);
            square.AddToy(compuer);

            square.PrintState();

            square.ChangeDepth(20);
            square.ChangeHeight(30);
            square.ChangeSpeed(40);

            square.PrintState();
        }
    }
}
