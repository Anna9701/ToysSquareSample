using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium1.Interfaces
{
    interface IAccelerate
    {
        void Accelerate(int change);

        int getSpeed();
    }
}
