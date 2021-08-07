using System;

namespace _08StrategicsPattern
{
    public class DataStore
    {
        private int[] data;

        public DataStore(int[] data)
        {
            this.data = data;
        }

        public object SumofOdd()
        {
            var sum = 0;
            foreach (var d in data)
            {
                if (d % 2 == 1) { sum = +d; }
            }

            return sum;
        }

        internal object ProductOfEvent()
        {
            var prod = 1;
            foreach (var d in data)
            {
                if (d % 2 == 0)
                {
                    prod *= d;
                }
                
            }
            return prod;
        }
    }
}