using System;

namespace _02Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            //saját hibakezelés try-catch-finally
            try
            {
                Console.WriteLine("Main try ág indul");

                throw new Exception("Valami nem stimmel");
                Console.WriteLine("Main try ág vége");
            }
            catch (Exception)
            {
                //ez a kód fut le ha hiba történik a try -ban és a szűrőfeltételre igaz(Exception)
                Console.WriteLine("Main catch ág indul");
                Console.WriteLine("Main catch ág vége");
            }
            finally
            {
                //ez mindenképen végrehajtódik a try és a catch -től függetlenül
                Console.WriteLine("Main finally ág indul");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Main finally ág vége");
               
            }
            

            Console.ReadLine();
        }
    }
}
