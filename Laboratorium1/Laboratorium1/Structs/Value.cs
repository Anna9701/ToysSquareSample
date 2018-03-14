using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium1.Structs
{
    struct Value
    {
        private decimal price;
        private decimal sentimentalPrice;

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                } else
                {
                    throw new FormatException();
                }
            }
        }


        public decimal SentimentalPrice
        {
            get
            {
                return sentimentalPrice;
            }
            private set
            {
                if (value > 0)
                {
                    sentimentalPrice = value;
                } else
                {
                    throw new FormatException();
                }
            }
        }

        public Value(decimal price, decimal sentimentalPrice)
        {
            this.price = price;
            this.sentimentalPrice = sentimentalPrice;
        }
    }
}
