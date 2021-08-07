using System;
using System.Drawing;

namespace _04GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            while (!Console.KeyAvailable)
            {
                // Így nem szabad használni mert sok memóriát használl és a mem ürítésnél sok proc
                // időt fog hhasználni
                // var bitmap = new Bitmap(1280, 1024);
                                
                using (var bitmap = new Bitmap(1280, 1024)) { }
             
            }

            Console.WriteLine("Hello World!");
        }
    }
}
