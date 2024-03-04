using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en
{
    internal class Direction
    {
        private string _source;     // Станция отправления 

        private string _destination; // Станция прибытия

        public Direction(string source,string destination) 
        {
            _source = source;

            _destination = destination;
        }

        public string GetSourse()
        {
            return _source;
        }

        public string GetDestination()
        {
            return _destination;
        }
    }
}