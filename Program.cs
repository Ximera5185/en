﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Depot depot = new Depot();

            depot.Work();

            Console.ReadKey();
        }
    }
}
