namespace Laboratorium1.Interfaces
{
    interface IToysSquare
    {
        void AddToy(IToy toy);
        void ChangeSpeed(int change);
        void ChangeDepth(int change);
        void ChangeHeight(int change);

        void PrintState();
    }
}
