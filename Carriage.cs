namespace en
{
    internal class Carriage
    {        
        public Carriage()
        {
            int minValue = 10;
            int maxValue = 50;

            Capacity = UserUtils.GetRundomNumber(minValue,maxValue);
        }

        public int Capacity { get; private set; }
    }
}