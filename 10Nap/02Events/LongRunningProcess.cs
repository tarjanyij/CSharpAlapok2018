using System;
using System.Collections.Generic;
using System.Threading;

namespace _02Events
{
   
    public class LongRunningProcess 
    {
        

       public event EventHandler<EventDto> DataChanged;

        public void Start()
        {
            Console.WriteLine("LongRunningProcess: 0%");
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
        
        private void OnDataChanged(int data)
        {
            var callList = DataChanged;
            if (callList != null)
            {
                callList(this, new EventDto(data));
            }
        }

        private void SendMessage()
        {
            OnDataChanged(Data);

                           
        }
        
    }
}