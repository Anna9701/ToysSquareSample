using System;
using Laboratorium1.Structs;

namespace Laboratorium1.Interfaces
{
    interface IToy
    {
        string State { get; }

        String Name { get; }
        double Age { get; set; }
        Decimal CurrentValue { get; }
        Value Value { get; set; }
        event EventHandler ValueChanged;
    }
}
