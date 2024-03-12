using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en
{
    internal class Depot
    {
        List<Train> trains = new List<Train>();

        

        int tickets;
        public Direction SetDestination()                    // Установить направеление ЗАЧЕМ ТУТ ЭТОТ МЕТОД ?
        {
            return  new Direction();      // Создаем направление
        }

        public int SellTickets()                        // Продажа билетов 
        {
            Random random = new Random();

           return random.Next(10,50);
        }

        public Carriage CreateCarriage(int tickets) 
        {
            for (int i = tickets; i > 0;)
            {

                Carriage carriage = new Carriage();

                i -= carriage.GetCapacity();

                return carriage;
            }

        }

        public void CreateTrains() 
        {
            trains.Add(new Train(SetDestination(),CreateCarriage(SellTickets())));
        }

        public void Work() 
        {
            string inputUser = "";

            while (true)
            {
                
                Console.WriteLine("Введите 1 для создания направления");

                inputUser = Console.ReadLine();
                
                switch (inputUser)
                {
                    case "1":
                        SetDestination();
                        break;

                    case "2":
                        SellTickets();
                        break;

                    case "3":
                        CreateCarriage(ref tickets);
                        break;

                    case "4":
                        CreateTrains();
                        break;
                }
            }
        }
    }
}
