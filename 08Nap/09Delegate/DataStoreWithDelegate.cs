using System;

namespace _09Delegate
{
    public class DataStoreWithDelegate
    {
        private int[] data;

        //függvénx definició
        public delegate int ProcessDef(int[] data);

        public DataStoreWithDelegate(int[] data)
        {
            this.data = data;
        }

        public int Process(ProcessDef strategy)
        {
            //todo:ellenörzés
            return strategy(data);
        }
        
        public int Process2(Func<int[],int> strategy)
        {
            return strategy(data);
        }

        internal int Process3(Func<int[], int> strategy)
        {
            return strategy(data);
        }
    }
}