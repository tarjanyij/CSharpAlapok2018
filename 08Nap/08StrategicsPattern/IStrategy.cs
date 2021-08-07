using System;
using System.Collections.Generic;
using System.Text;

namespace _08StrategicsPattern
{
    public interface IStrategy
    {
        int Process(int[] data);
    }
}
