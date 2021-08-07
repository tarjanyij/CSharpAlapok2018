using System;

namespace _02Events
{
    public class EventDto : EventArgs

    {
        public int Data;

        public EventDto(int data)
        {
            this.Data = data;
        }
    }
}