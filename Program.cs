using System;

namespace en
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Depot depot = new Depot();

            depot.Work();

            Console.ReadKey();
        }
    }
}
