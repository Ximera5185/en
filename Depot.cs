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

        public void SetDestination()                    // Установить направеление ЗАЧЕМ ТУТ ЭТОТ МЕТОД ?
        {
            Direction direction = new Direction();      // Создаем направление
        }

        public int SellTickets()                        // Продажа билетов 
        {
            Random random = new Random();

           return random.Next(10,50);
        }

        public void CreateCarriage(int tickets) 
        {
            for (int i = tickets; i > 0;)
            {

            Carriage carriage = new Carriage();

                i -= carriage.GetCapacity();
            }

            
            
        }
    }
}
