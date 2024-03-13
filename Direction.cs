using System;

namespace en
{
    internal class Direction                                            // направление
    {
         public string Source { get; private set; }                                         // Станция отправления 

        public string Destination { get; private set; }                                    // Станция прибытия
        // методы создания вывести в класс депо
        public Direction() 
        {
            Source = GetSourse();

            Destination = GetDestination();
        }

        public string GetSourse()
        {
            Console.WriteLine("Введите станцию отправления");

            Source = Console.ReadLine();

            return Source;
        }

        public string GetDestination()
        {
            Console.WriteLine("Введите станцию прибытия");

            Destination = Console.ReadLine();

            return Destination;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Отправление {Source} Прибытие {Destination}");
        }   
    }
}