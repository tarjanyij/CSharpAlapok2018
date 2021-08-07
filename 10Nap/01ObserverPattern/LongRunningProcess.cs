using System;
using System.Collections.Generic;
using System.Threading;

namespace _01ObserverPattern
{
    /// <summary>
    /// Egy hosszú folyamatot elvégző osztály példája
    /// Ő értesíti a többieket, ha valami történt
    /// Megfigyelhető/megfigyelt szereplő (Observeble)
    /// </summary>
    public class LongRunningProcess :IMessage
    {
        

        private readonly List<INotifiable> observers= new List<INotifiable>();

        public void Subscribe(INotifiable observer)
        {
            observers.Add(observer);
        }

        public void UnSubscribe(INotifiable observer)
        {
            observers.Remove(observer);
        }

        public void Start()
        {
            Console.WriteLine("LongRunningProcess: 0%");
            //todo: értesíteni a kíváncsiskodókat (Observer)
            Data = 0;
            

            Thread.Sleep(1000);

            Console.WriteLine("LongRunningProcess: 25%");
            Data = 25;
            

            Thread.Sleep(1000);

            Console.WriteLine("LongRunningProcess: 50%");
            Data = 50;
            

            Thread.Sleep(1000);

            Console.WriteLine("LongRunningProcess: 75%");
            Data = 75;
            

            Thread.Sleep(1000);

            Console.WriteLine("LongRunningProcess: 100%");
            Data = 100;
            

        }
        private int data;
        public int Data
        {
            get { return data; }
            set
            {
                if ( data == value ) { return; }

                data = value;
                SendMessage();
            }
        }
        public string Text { get; set; }
        /// <summary>
        /// értesítjük az összes megfigyelőt
        /// </summary>
        /// <param name="data">az információ, amit küldenem kell</param>

        private void SendMessage()
        {
            foreach (var observer in observers)
            {
                observer.Message(this);
            }
                
        }
        
    }
}