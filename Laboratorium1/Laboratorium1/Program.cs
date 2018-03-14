using System;
using Laboratorium1.Implementations;
using Laboratorium1.Interfaces;
using Laboratorium1.Structs;

namespace Laboratorium1
{
    class Program
    {
        public static int MAX_TOYS_NUMBER => 7;

        static void Main(string[] args)
        {
            IToysSquare square = InitSquare();
            square.ToysNumberChanged += Square_ToysNumberChanged;
            SampleSquareTest(square);
            Console.ReadKey();
            
        }

        private static void Square_ToysNumberChanged(object sender, EventArgs e)
        {
            if (square.ToysNumber > MAX_TOYS_NUMBER)
            {

            }
        }

        static private IToysSquare InitSquare()
        {
            IToy car = Car.CreateSampleCar();
            IToy plane = Plane.CreateSamplePlane();
            IToy submarine = Submarine.CreateSampleSubmarine();
            IToy computer = Computer.CreateSampleComputer();
            IToysSquare square = new ToysSquare();

            square.AddToy(car);
            square.AddToy(plane);
            square.AddToy(submarine);
            square.AddToy(computer);


            computer.Value = new Value(computer.Value.Price + 500M, computer.Value.SentimentalPrice);

            return square;
        }

        static private void SampleSquareTest(IToysSquare square)
        {
            square.PrintState();

            square.ChangeDepth(20);
            square.ChangeHeight(30);
            square.ChangeSpeed(40);

            square.PrintState();

            
        }
    }

}



/*
 * struktura wartość, 2 pola (double, decimal), cena i wartośćSentymentalna, konstruktor, właściwości pozwalające na dostęp do pól i walidujące (przy zapisie) wartości: muszą byc nieujemne
 * 
 * klase bazową zabawka, mająca polew wartoscBazowa(typu Wartosc) oraz pole Wiek (typu double) z odpowiedniami metodami dostępowymi, a także pole WartoscAktualna, zwracającą wartosc wyliczona
 * na podsawie wartosci bazowej i wieku
 * 
 * w pokoju zabawek oraz klasie Zabawka utowrzyc zdarzenia, wywoływanie odpowiednio: w przypadku zwiększenia liczby zabawek w pokoju, w przypadku zwiekszenia wartosci. Użć zdarzen do
 * reagowania na sytuacje, gdy wartosc zabawek w pokoju przekroczy okresloną wartość
 * 
 * set in toy powinien sygnalizowac zdarzenie
 * add w toys square powinien sygnalziwoac zdarzenie
 * toys square powinien odbierac zdarzenie i reagowac na przekroczenie wartosci
 */