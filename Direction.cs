using System;

namespace en
{
    internal class Direction                                            // направление
    {
        // методы создания вывести в класс депо
        public Direction(string startPoint, string endPoint)
        {
            StartPoint = startPoint;

            EndPoint = endPoint;
        }

        public string StartPoint { get; private set; }                                         // Станция отправления 

        public string EndPoint { get; private set; }                                    // Станция прибытия

        /*public string GetSourse()
        {
            Console.WriteLine("Введите станцию отправления");

            StartPoint = Console.ReadLine();

            return StartPoint;
        }

        public string GetDestination()
        {
            Console.WriteLine("Введите станцию прибытия");

            EndPoint = Console.ReadLine();

            return EndPoint;
        }*/

        public void ShowInfo()
        {
            Console.WriteLine($"Отправление {StartPoint} Прибытие {EndPoint}");
        }
    }
}