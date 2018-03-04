using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium1.Interfaces
{
    interface IToysSquare
    {
        void addToy(IToy toy);
        void changeSpeed(int change);
        void changeDepth(int change);
        void changeHeight(int change);

        void getState();
    }
}
