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

        public void SetDestination(string source, string destination) 
        {
            Direction direction = new Direction(source, destination);
        }

        public void SellTickets() { }

       
    }
}
