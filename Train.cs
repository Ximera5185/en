using System;
using System.Collections.Generic;

namespace en
{
    internal class Train
    {
        private List<Carriage> _carriages = new List<Carriage>();

        private Direction _direction;

        private int _quantityTicketsSold;

        private int _availableSeats;

        public Train(Direction direction, List<Carriage> carriages, int quantityTicketsSold)
        {
            _direction = direction;

            _carriages = carriages;

            _quantityTicketsSold = quantityTicketsSold;

            _availableSeats = ReturnAvailableSeats(carriages, _quantityTicketsSold);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Направление {_direction.StartPoint} - {_direction.EndPoint}\n" +
            $"Колличество вагонов {_carriages.Count}\n" +
            $"Колличество свободных мест {_availableSeats}");
        }

        private int ReturnAvailableSeats(List<Carriage> carriages, int _quantityTicketsSold)
        {
            int wagonСapacity = 0;

            foreach (Carriage carriage in carriages)
            {
                wagonСapacity += carriage.Capacity;
            }

            return wagonСapacity - _quantityTicketsSold;
        }
    }
}