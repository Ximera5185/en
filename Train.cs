using System;
using System.Collections.Generic;

namespace en
{
    internal class Train
    {
        List<Carriage> _carriages = new List<Carriage>();

        private Direction _direction;

        private int _quantityTicketsSold;

        private int _availableSeats;

        public Train(Direction direction, List<Carriage> carriages, int quantityTicketsSold)
        {
            _direction = direction;

            _carriages = carriages;

            _quantityTicketsSold = quantityTicketsSold;

            _availableSeats = CheckVacancies(carriages,_quantityTicketsSold);
        }

        public void ShowInfo() 
        {         
            Console.WriteLine($"Направление {_direction.StartPoint} - {_direction.EndPoint}\n" +
            $"Колличество вагонов {_carriages.Count}\n" +
            $"Колличество свободных мест {_availableSeats}");
        }

        private int CheckVacancies(List<Carriage> carriages, int _quantityTicketsSold) 
        {
            int wagonСapacity = 50;

            return carriages.Count * wagonСapacity - _quantityTicketsSold;
        }
    }
}