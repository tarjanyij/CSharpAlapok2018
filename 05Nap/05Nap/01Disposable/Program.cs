using System;

namespace _01Disposable
{
    class Program
    {
        static void Main(string[] args)
        {
            //var takarito = new ItSelfCleaner();

            //try // megpróbálja a kódblokkot végrehajtani
            //{

            //}
            //catch (Exception)// ha hiba van
            //{

            //    throw;
            //}
            //finally // mindenképpen lefut
            //{
            //    ((IDisposable)takarito).Dispose();
            //}

            // A sok kód heyett ezt is lehet használni
            //a fordító garantálja nekünk ugyanezt
            using (var takaito = new ItSelfCleaner())
            {
                //ebben a kódblokban van a kód ez a try ág,és ezután biztos hogy lefut a megfelelő dispose függvény
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
