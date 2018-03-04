using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorium1.Implementations;
using Laboratorium1.Interfaces;

namespace Laboratorium1
{
    class Program
    {
        static void Main(string[] args)
        {
            IToy car = new Car();
            IToy plane = new Plane();
            IToy submarine = new Submarine();
            IToy compuer = new Computer();
            IToysSquare square = new ToysSquare();
            square.addToy(car);
            square.addToy(plane);
            square.addToy(submarine);
            square.addToy(compuer);
            square.changeDepth(20);
            square.changeHeight(30);
            square.changeSpeed(40);
            square.getState();
            while (true) ;
        }
    }
}
