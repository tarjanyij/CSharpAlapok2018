using System;

namespace _02Events
{
    public class UserInterface
    {
        internal void Message(object sender, EventDto e)
        {
            var data = (LongRunningProcess)sender;
            Console.WriteLine($"UserInterface: {data.Data}");

            Console.WriteLine($"UserInterface: {e.Data}");
        }
    }
}