using System;

namespace en
{
    static class UserUtils
    {
       private static Random _random = new Random();
        static public int GetRundomNumber(int minValue,int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }
    }
}