using System;
using System.Collections.Generic;

namespace _02Ienurable
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var item in ShoppingList())
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }

        private static IEnumerable<string> ShoppingList()
        {
            yield return "1 kg marhahús";
            yield return "1 lt tej";
            yield return "1 kg cukor";
            yield return "1 kg kenyér";

        }

    }
}
