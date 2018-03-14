using System;
using Laboratorium1.Structs;

namespace Laboratorium1.Interfaces
{
    interface IToy
    {
        String Name { get; }
        double Age { get; set; }
        Decimal CurrentValue { get; }
        Value Value { get; set; }
        event EventHandler ValueChanged;
    }
}
