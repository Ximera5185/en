using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en
{
    internal class Direction                                            // направление
    {
         public string Source { get; private set; }                                         // Станция отправления 

        public string Destination { get; private set; }                                    // Станция прибытия

        public Direction() 
        {
            Source = GetSourse();

            Destination = GetDestination();
        }

        public string GetSourse()
        {
            Console.WriteLine("Введите станцию отправления");

            Source = Console.ReadLine();

            return Source;
        }

        public string GetDestination()
        {
            Console.WriteLine("Введите станцию прибытия");

            Destination = Console.ReadLine();

            return Destination;
        }
    }
}