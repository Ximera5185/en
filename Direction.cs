using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en
{
    internal class Direction                                            // направление
    {
        private string _source;                                         // Станция отправления 

        private string _destination;                                    // Станция прибытия

        public Direction() 
        {
            _source = GetSourse();

            _destination = GetDestination();
        }

        public string GetSourse()
        {
            Console.WriteLine("Введите станцию отправления");

            _source = Console.ReadLine();

            return _source;
        }

        public string GetDestination()
        {
            Console.WriteLine("Введите станцию прибытия");

            _destination = Console.ReadLine();

            return _destination;
        }
    }
}