using System;

namespace _11FuncActionLambda
{
    class Program
    {
        delegate int SquariSngDef(int x);

        static void Main(string[] args)
        {
            SquariSngDef squaringProcessList = SquaringFunc;
            
            Console.WriteLine($"2 a négyzeten: {squaringProcessList(2)}");


            squaringProcessList = x => x * x;

            squaringProcessList = (x) => { return x * x; };


            //egyszerűsítés Action és Func használata

            Action<int, int> multiplicationprocesslist = (a, b) => Console.WriteLine($"A szorzás eredménye: {a*b}");
            // vagy kodblokban
            multiplicationprocesslist = (a, b) =>
            {
                Console.WriteLine($"A szorzás kodblkkos eredménye: {a * b}");
            };


            //a Func egy nem void-al visszatérő delegate  def
            Func<int, int> squaringProcessList2 = x => x * x;
            Console.WriteLine($"3 anégyzeten: {squaringProcessList2(3)}");

            Func<int, int, string> multiplicationProcessList2 = (i, j) => $"{i} és {j} szorzata :{i * j}";
            Console.WriteLine(multiplicationProcessList2(4,9));



            Console.ReadLine();
        }

        private static int SquaringFunc(int x)
        {
            return x * x;
        }
    }
}
