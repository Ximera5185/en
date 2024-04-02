using System;
using System.Collections.Generic;

namespace en
{
    internal class Depot
    {
       private List<Train> _trains = new List<Train>();

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

            return UserUtils.GetRundomNumber(minValue,maxValue);
        }

        public List<Carriage> CreateCarriages(int tickets)
        {
            int capacity = new Carriage().Capacity;

            List<Carriage> carriages = new List<Carriage>();

            int count = tickets / capacity;

            if (tickets > capacity)
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
            string inputUserCommand;
            string exitProgrammCommand = "Exit";
            string createTainCommand = "Enter";

            bool isProgrammWork = true;

            while (isProgrammWork)
            {
                Console.WriteLine($"Нажмите {createTainCommand} для формирования нового поезда , для выхода из программы введите {exitProgrammCommand}");

                inputUserCommand = Console.ReadLine();

                if (inputUserCommand == exitProgrammCommand)
                {
                    isProgrammWork = false;
                }
                else
                {
                    CreateTrain();
                }

                Console.ReadKey();
            }
        }
    }
}