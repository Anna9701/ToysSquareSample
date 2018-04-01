using Laboratorium1.Exceptions;
using Laboratorium1.Implementations;
using Laboratorium1.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

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
            toysSquare.ToysNumberChanged += this.ToyValueChanged;
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
            lock (toysSquare.Toys)
            {
                toysSquare.ChangeHeight(height);
                toysSquare.ChangeSpeed(speed);
                toysSquare.ChangeDepth(depth);
                PrintToysSquareState();
            }
        }

        public void PrintToysSquareState() => toysSquare.PrintState();

        private void RemoveToyFromSquare (IToy toy)
        {
            lock (toysSquare.Toys)
            {
                toysSquare.RemoveToyFromSquare(toy);
            }
        }

        public void AddToysToSquareEndlessly()
        {
            Thread addSampleCarThread, addSamplePlaneThread, addSampleSubmarineThread, addSampleComputerThread;
            while (true)
            {
                addSampleCarThread = new Thread(() => AddToyToSquare(Car.CreateSampleCar()));
                addSamplePlaneThread = new Thread(() => AddToyToSquare(Plane.CreateSamplePlane()));
                addSampleComputerThread = new Thread(() => AddToyToSquare(Computer.CreateSampleComputer()));
                addSampleSubmarineThread = new Thread(() => AddToyToSquare(Submarine.CreateSampleSubmarine()));

                addSampleCarThread.Start();
                addSampleComputerThread.Start();
                addSamplePlaneThread.Start();
                addSampleSubmarineThread.Start();

                Thread.Sleep(500);
            }
        }

        public void RemoveFirstToyFromSquareEndlessly()
        {
            Thread mainThread = new Thread(() => {
            while (true)
                {
                    lock (toysSquare.Toys) {
                        var toys = (LinkedList<IToy>)toysSquare.Toys;
                        Thread removeToysThread = new Thread(() => RemoveToyFromSquare(toys.First.Value));
                        removeToysThread.Start();
                    }
                    Thread.Sleep(500);
                }
            });
            mainThread.Start();
        }

        public void ChangeToysParametersEndlessly()
        {
            Thread thread = new Thread(() =>
            {
                Random random = new Random();
                const int maxParameterVaue = 100;
                while (true)
                {
                    int speed = random.Next(maxParameterVaue);
                    int depth = random.Next(maxParameterVaue);
                    int height = random.Next(maxParameterVaue);
                    Thread changeParametersThread = new Thread(() => ChangeToysParameters(depth, height, speed));
                    changeParametersThread.Start();
                    Thread.Sleep(500);
                }
            });
            thread.Start();
        }
    }
}
