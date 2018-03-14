namespace Laboratorium1.Interfaces
{
    interface IAccelerate
    {
        string State { get; }

        void Accelerate(int change);
    }
}
