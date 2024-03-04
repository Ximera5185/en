using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en
{
    internal class Carriage
    {
        private int _capacity;        // вместимость

        public Carriage(int capacity) 
        {
            _capacity = capacity;
        }
        public int GetCapacity()
        {
            return _capacity;
        }
    }
}
