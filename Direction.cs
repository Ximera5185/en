using System;

namespace en
{
    internal class Direction                                            
    {
        public Direction(string startPoint, string endPoint)
        {
            StartPoint = startPoint;

            EndPoint = endPoint;
        }

        public string StartPoint { get; private set; }                                       

        public string EndPoint { get; private set; }                                    

        public void ShowInfo()
        {
            Console.WriteLine($"Отправление {StartPoint} Прибытие {EndPoint}");
        }
    }
}