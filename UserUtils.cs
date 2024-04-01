using System;

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