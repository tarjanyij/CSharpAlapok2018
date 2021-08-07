using System;

namespace _09DelegateDef
{
    class Program
    {
        delegate void DelegateDef(string msg);


        static void Hi(string txt)
        {
            Console.WriteLine($"Szia, {txt}");
        }
        static void By(string str)
        {
            Console.WriteLine($"Viszlát {str}");
        }

        static void Main(string[] args)
        {
            DelegateDef a;
            DelegateDef b;
            DelegateDef c;
            DelegateDef d;

            a = Hi;
            b = By;
            c = a + b;
            d = c - a;


            Console.WriteLine("maghivjuk az a listát");
            a("a");
            Console.WriteLine("maghivjuk a b listát");
            b("b");
            Console.WriteLine("maghivjuk az c listát");
            c("c");
            Console.WriteLine("maghivjuk az d listát");
            d("d");



            Console.WriteLine("vége");
            Console.ReadLine();
        }
    }
}
