﻿using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int number = int.Parse(Console.ReadLine());
            double bonus = 0;
            //conditions
            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 1000)
            {

                bonus = number * 0.1;
            }
            else
            {
                bonus = number * 0.2;
            }
            if (number % 2 == 0)
            {
                bonus += 1;
            }
            else if (number % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
