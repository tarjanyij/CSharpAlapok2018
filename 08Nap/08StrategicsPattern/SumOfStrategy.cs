namespace _08StrategicsPattern
{
    internal class SumOfStrategy : IStrategy
    {
        public SumOfStrategy()
        {
        }

        public int Process(int[] data)
        {
            var sum = 0;
            foreach (var d in data)
            {
                if (d % 2 == 1) { sum = +d; }
            }

            return sum;
        }
}