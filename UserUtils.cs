using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en
{
    static class UserUtils
    {
        static Random random = new Random();
        static public int GetRundomNumber()
        {
            int minValue = 100;
            int maxValue = 500;

            return random.Next(minValue, maxValue);
        }
    }
}
