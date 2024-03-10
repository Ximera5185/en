using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en
{
    internal class Train
    {
       // List<Carriage> carriages = new List<Carriage>();

        private Direction _direction;

        public Train(Direction direction)
        {
           _direction = direction;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Направление {_direction.Source} - {_direction.Destination}") ;
        }
    }
}
