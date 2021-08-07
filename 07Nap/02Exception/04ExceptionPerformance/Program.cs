
using System;
using System.Diagnostics;

namespace _04ExceptionPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    
                }
            }
            Console.WriteLine($"eltelt idő : {sw.ElapsedTicks}");
            sw.Restart();

            for (int i = 0; i < 100; i++)
            {

            }

            sw.Stop();
            Console.WriteLine($"eltelt idő : {sw.ElapsedTicks}");
           
            Console.ReadLine();
        }
    }
}
