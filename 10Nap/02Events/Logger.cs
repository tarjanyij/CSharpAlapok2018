using System;

namespace _02Events
{
    public class Logger
    {
        internal void Message(object sender, EventDto e)
        {
            var data = (LongRunningProcess)sender;
            Console.WriteLine($"Logger: {data.Data}");

            Console.WriteLine($"Logger: {e.Data}");
        }
    }
}