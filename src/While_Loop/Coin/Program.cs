﻿using System;

namespace Coin
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double convert = change * 100;
            int cent = (int)convert;
            int coins = 0;
            while (cent > 0)
            {
                if (cent - 200 >= 0)
                {
                    coins++;
                    cent -= 200;
                    continue;
                }
                else if (cent - 100 >= 0)
                {
                    coins++;
                    cent -= 100;
                    continue;
                }
                else if (cent - 50 >= 0)
                {
                    coins++;
                    cent -= 50;
                    continue;
                }
                else if (cent - 20 >= 0)
                {
                    coins++;
                    cent -= 20;
                    continue;
                }
                else if (cent - 10 >= 0)
                {
                    coins++;
                    cent -= 10;
                    continue;
                }
                else if (cent - 5 >= 0)
                {
                    coins++;
                    cent -= 5;
                    continue;
                }
                else if (cent - 2 >= 0)
                {
                    coins++;
                    cent -= 2;
                    continue;
                }
                else if (cent - 1 >= 0)
                {
                    coins++;
                    cent -= 1;
                    continue;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
