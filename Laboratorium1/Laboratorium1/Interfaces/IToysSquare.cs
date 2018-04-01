using System;
using System.Collections.Generic;

namespace Laboratorium1.Interfaces
{
    interface IToysSquare
    {
        event EventHandler ToysNumberChanged;

        void AddToy(IToy toy);
        void ChangeSpeed(int change);
        void ChangeDepth(int change);
        void ChangeHeight(int change);
        int ToysNumber { get; }
        decimal AllToysValue { get; }
        void PrintState();
        void RemoveToyFromSquare(IToy toy);
        void RemoveAllToysFromSquare();
        ICollection<IToy> Toys { get; }
    }
}
