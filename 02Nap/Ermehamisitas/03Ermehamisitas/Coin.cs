﻿using System;

namespace _03Ermehamisitas
{
   public class Coin
    {

        Random random = new Random();

        public int collect()
        {
            return random.Next(0, 2);
        }
    }
}