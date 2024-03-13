using System;
using System.Collections.Generic;

namespace en
{
    internal class Depot
    {
        List<Train> _trains = new List<Train>();

        public Direction CreateDirection()                    // Установить направеление ЗАЧЕМ ТУТ ЭТОТ МЕТОД ?
        {
            return new Direction();      // Создаем направление
        }

        public int SellTickets()                        // Продажа билетов 
        {
            Random random = new Random();

            return random.Next(10, 50);
        }

        public Carriage CreateCarriage(int tickets)
        {
            for (int i = tickets; i > 0;)
            {

                Carriage carriage = new Carriage();

                i -= carriage.GetCapacity();

                return carriage;// ошибка
            }

            return null;
        }

        public void CreateTrains(Direction direction, List<Carriage> carriages)
        {
            _trains.Add(new Train(direction, carriages));// у поезда должно быть поле кол прод билетов
        }

        public void Work()
        {
            List<Carriage> carriages = new List<Carriage>();

            Direction direction = null;

            int tickets = 0;

            string inputUser = "";


            while (true)
            {

                Console.WriteLine("Введите 1 для создания направления");

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case "1":
                        direction = CreateDirection();
                        break;

                    case "2":
                        tickets = SellTickets();
                        break;

                    case "3":
                        carriages.Add(CreateCarriage(tickets));
                        break;

                    case "4":
                        CreateTrains(direction, carriages);//оставить один метод
                        break;
                }
            }
        }
    }
}