using System;
using System.Collections.Generic;

namespace en
{
    internal class Depot
    {
        List<Train> _trains = new List<Train>();

        public void CreateTrain()
        {
            Direction direction = CreateDirection();

            int soldTickets = SellTickets();

            Console.WriteLine($"По данному направлению было продано {soldTickets} билетов");

            List<Carriage> carriages = CreateCarriages(soldTickets);

            Console.WriteLine($"К поезду было добавлено {carriages.Count} вагонов");

            Train train = new Train(direction, carriages, soldTickets);

            _trains.Add(train);

            Console.WriteLine($"Сформирован поезд :");

            train.ShowInfo();

            Console.ReadLine();
        }

        private Direction CreateDirection()
        {
            string startPoint;

            string endPoint;

            do
            {
                Console.WriteLine("Введите станцию отправления");

                startPoint = Console.ReadLine();

                Console.WriteLine("Введите станцию прибытия");

                endPoint = Console.ReadLine();
            }
            while (startPoint == endPoint);

            return new Direction(startPoint, endPoint);
        }

        private int SellTickets()
        {
            int minValue = 100;
            int maxValue = 500;

            Random random = new Random();

            return random.Next(minValue, maxValue);
        }

        public List<Carriage> CreateCarriages(int tickets)
        {
            int capacity = new Carriage().Capacity;

            List<Carriage> carriages = new List<Carriage>();

            int count = tickets / capacity;

            if (tickets % capacity != 0)
            {
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                carriages.Add(new Carriage());
            }

            return carriages;
        }

        public void Work()
        {
            bool _isProgrammWork = true;

            string inputUserCommand;

            Console.WriteLine("Нажмите Enter для формирования нового поезда , для выхода ихпрограммы введите Exit");

            inputUserCommand = Console.ReadLine();

            if (inputUserCommand == "Exit")
            {
                _isProgrammWork = false;
            }

            while (_isProgrammWork)
            {
                CreateTrain();

                Console.ReadKey();
            }
        }
    }
}