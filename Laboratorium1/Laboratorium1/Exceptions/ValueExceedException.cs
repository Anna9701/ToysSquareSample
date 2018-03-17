using System;

namespace Laboratorium1.Exceptions
{
    class ValueExceedException : Exception
    {
        private decimal allToysValue;
        private decimal maxValue;

        public ValueExceedException(decimal allToysValue, decimal maxValue)
        {
            this.allToysValue = allToysValue;
            this.maxValue = maxValue;
        }

        public override string Message
        {
            get
            {
                return allToysValue + " is larger that possible toys value: " + maxValue;
            }
        }
    }
}
