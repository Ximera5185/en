using System;
using System.Collections.Generic;

namespace en
{
    internal class Train
    {
        List<Carriage> _carriages = new List<Carriage>();

        private Direction _direction;

        
        public Train(Direction direction, List<Carriage> carriages)
        {
           _direction = direction;

            _carriages = carriages;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Направление {_direction.Source} - {_direction.Destination}") ;
        }

        public void ShowCarriges() 
        {
            int capacity;

            foreach (Carriage carriage in _carriages)
            {
                capacity = carriage.GetCapacity();

                Console.WriteLine($"Вагон{_carriages.IndexOf(carriage) + 1} - вместимость{capacity}");
            }
        }
    }
}
