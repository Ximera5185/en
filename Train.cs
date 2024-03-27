using System;
using System.Collections.Generic;

namespace en
{
    internal class Train
    {
        List<Carriage> _carriages = new List<Carriage>();

        private Direction _direction;

        private int _quantityTicketsSold;

        public Train(Direction direction, List<Carriage> carriages, int quantityTicketsSold)
        {
            _direction = direction;

            _carriages = carriages;

            _quantityTicketsSold = quantityTicketsSold;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Направление {_direction.StartPoint} - {_direction.EndPoint}") ;

            Console.WriteLine($"Колличество вагонов {_carriages.Count}");
        }

        public void ShowCarriges() 
        {
            int capacity;

            /* foreach (Carriage carriage in _carriages)
             {
                 capacity = carriage.GetCapacity();

                 Console.WriteLine($"Вагон{_carriages.IndexOf(carriage) + 1} - вместимость{capacity}");
             }*/

            Console.WriteLine($"Колличество вагонов {_carriages.Count}");
        }
    }
}
