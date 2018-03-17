using Laboratorium1.Exceptions;
using Laboratorium1.Interfaces;
using System;

namespace Laboratorium1
{
    class ToysSquareSample
    {
        private IToysSquare toysSquare;
        private readonly uint MAX_TOYS_NUMBER;
        private readonly decimal MAX_VALUE;

        public ToysSquareSample(IToysSquare square, uint maximumToysNumber, decimal maximumToysValue)
        {
            this.toysSquare = square;
            MAX_TOYS_NUMBER = maximumToysNumber;
            MAX_VALUE = maximumToysValue;
            toysSquare.ToysNumberChanged += this.ToysNumberChanged;
        }

        public void AddToyToSquare(IToy toy)
        {
            toy.ValueChanged += this.ToyValueChanged;
            toysSquare.AddToy(toy);
        }

        private void ToysNumberChanged(object sender, EventArgs e)
        {
            if (toysSquare.ToysNumber > MAX_TOYS_NUMBER)
            {
                throw new ToysAmountExceedException(toysSquare.ToysNumber, MAX_TOYS_NUMBER);
            }
        }

        private void ToyValueChanged(object sender, EventArgs e)
        {
            if (toysSquare.AllToysValue > MAX_VALUE)
            {
                throw new ValueExceedException(toysSquare.AllToysValue, MAX_VALUE);
            }
        }

        public void ChangeToysParameters(int depth, int height, int speed)
        {
            toysSquare.ChangeHeight(height);
            toysSquare.ChangeSpeed(speed);
            toysSquare.ChangeDepth(depth);
        }

        public void PrintToysSquareState() => toysSquare.PrintState();


    }
}
