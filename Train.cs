using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en
{
    internal class Train
    {
        List<Carriage> carriages = new List<Carriage>();

        private Direction _direction;

        private Carriage _carriage;
        public Train(Direction direction, Carriage carriage)
        {
           _direction = direction;

           _carriage = carriage;

           carriages.Add(carriage);
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Направление {_direction.Source} - {_direction.Destination}") ;
        }

        public void ShowCarriges() 
        {
            int capacity;

            foreach (Carriage carriage in carriages)
            {
                capacity = carriage.GetCapacity();

                Console.WriteLine($"Вагон{carriages.IndexOf(carriage) + 1} - вместимость{capacity}");
            }
        }
    }
}
