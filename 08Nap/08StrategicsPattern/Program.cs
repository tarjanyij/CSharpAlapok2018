
using System;

namespace _08StrategicsPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new DataStore(data: new int[] { 1, 3, 5, 3, 4, 2, 7, 6 });

            var sum = store.SumofOdd();
            Console.WriteLine($"Páratlan számok összege: {sum}");

            sum = store.ProductOfEvent();
            Console.WriteLine($"Páros számok szorzata: {sum}");

            var storeWStrategy = new DataStoreWStrategy(data: new int[] { 1, 3, 5, 3, 4, 2, 7, 6 });

            IStrategy strategy = new SumOfStrategy();
            storeWStrategy.SetStrategy(strategy);
            sum = storeWStrategy.Process();
            Console.WriteLine($"Páratlan számok összege: {sum}");


            strategy = new ProductOfEventStrategy();
            storeWStrategy.SetStrategy(strategy);
            sum = storeWStrategy.Process();
            Console.WriteLine($"Páros számok sorzata: {sum}");


            Console.ReadLine();
        }
    }
}
