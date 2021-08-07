using System;

namespace _02Events

{
    class Program
    {
        static void Main(string[] args)
        {
            //a két alkalmazás modul, ami igényt tart az információra
            //ők a megfigyelők: (Observers)
            //naplózás
            var log = new Logger();

            //és felhasználói felület
            var ui = new UserInterface();

            //a hosszantartó folyamatunk
            var process = new LongRunningProcess();
            process.DataChanged += log.Message;
            process.DataChanged += ui.Message;
          
            process.Start();

            process.DataChanged -= log.Message;
            process.DataChanged -= ui.Message;
            Console.WriteLine("A folyamat lefutott");

            Console.ReadLine();
        }
    }
}