using System;

namespace _04ConstruktorFinalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Base();
            var midle = new Middle();
            var t = new Third();

            b = new Base(" Ez az alaposztály");

            b = new Base("Ez az alaposztály", "nem@mondom.meg");
            Console.WriteLine();

            m = new Middle();
            Console.WriteLine($"név:{m.Name}");

            m = new Middle("Ez amiddle", "middle@middle.hu");
            Console.WriteLine($"név:{m.Name}, e-mail : {m.Email}");

            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
