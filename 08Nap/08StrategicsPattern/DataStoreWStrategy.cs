using System;

namespace _08StrategicsPattern
{
    public class DataStoreWStrategy 
    {
        private int[] data;
        private IStrategy strategy;

        public DataStoreWStrategy(int[] data)
        {
            this.data = data;
        }

        public int Process()
        {
            throw new System.NotImplementedException();
        }

        internal void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
    }
}