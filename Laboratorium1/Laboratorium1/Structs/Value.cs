using System;

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
            private set { }
        }


        public decimal SentimentalPrice
        {
            get
            {
                return sentimentalPrice;
            }
            private set { }
        }

        public Value(decimal price, decimal sentimentalPrice)
        {
            this.price = price;
            this.sentimentalPrice = sentimentalPrice;
        }
    }
}
