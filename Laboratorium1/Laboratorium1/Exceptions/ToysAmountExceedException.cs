using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium1.Exceptions
{
    class ToysAmountExceedException : Exception
    {
        private int toysNumber;
        private uint maxToysNumber;

        public ToysAmountExceedException(int toysNumber, uint maxToysNumber)
        {
            this.toysNumber = toysNumber;
            this.maxToysNumber = maxToysNumber;
        }

        public override string Message
        {
            get
            {
                return toysNumber + " is larger that possible toys number: " + maxToysNumber;
            }
        }
    }
}
