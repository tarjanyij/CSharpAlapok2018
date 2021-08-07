using System;

namespace _09Delegate
{
    class Program
    {
        static void Main(string[] args)
        {

            var storeWithDelegate = new DataStoreWithDelegate(data: new int[] { 1, 3, 5, 3, 4, 2, 7, 6 });

            var sum = storeWithDelegate.Process(SumOfOdd);
            Console.WriteLine($"Páratlan számok összege: {sum}");

            sum = storeWithDelegate.Process(ProductOfEven);
            Console.WriteLine($"Páros számok szorzata: {sum}");


            //func használata
            sum = storeWithDelegate.Process2(SumOfOdd);
            Console.WriteLine($"Páratlan számok összege: {sum}");

            sum = storeWithDelegate.Process3(data => {
                var s = 0;
                foreach (var d in data)
                {
                    if (d % 2 == 1) { s = +d; }
                }

                return s;
            });
            Console.WriteLine($"Páratlan számok összege: {sum}");

            Console.ReadLine();
        }

        private static int ProductOfEven(int[] data)
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

        private static int SumOfOdd(int[] data)
        {
            var sum = 0;
            foreach (var d in data)
            {
                if (d % 2 == 1) { sum = +d; }
            }

            return sum;
        }
    }
}
