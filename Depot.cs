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

            List <Carriage> carriages = CreateCarriages(soldTickets);

            Console.WriteLine($"К поезду былот добавлено {carriages.Count} вагонов");

            Train train = new Train(direction, carriages, soldTickets);

            _trains.Add(train);// у поезда должно быть поле кол прод билетов

            Console.WriteLine($"Свормерован поезд :");

            train.ShowInfo();

            Console.WriteLine("Нажмите ентер для формирования нового поезда");

            Console.ReadLine();
        }

        // поправить меню
        // колличество свободных мест добавить в класс поезда в метод шовинфоы
        private Direction CreateDirection()                    // Установить направеление ЗАЧЕМ ТУТ ЭТОТ МЕТОД ?
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


            return new Direction(startPoint,endPoint);      // Создаем направление
        }

        private int SellTickets()                        // Продажа билетов 
        {
            Random random = new Random();

            return random.Next(100, 500);
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

            while (true)
            {
                CreateTrain();

                Console.ReadKey();
            }
        }
    }
}