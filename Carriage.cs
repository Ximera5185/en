using System;

namespace en
{
    internal class Carriage
    {
        private int _capacity;        // вместимость

        public Carriage()
        {
            Random random = new Random();

            _capacity = random.Next(10, 50);
        }
        public int GetCapacity()
        {
            return _capacity;
        }
    }
}
