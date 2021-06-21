using System;

namespace Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            int numofEggCartons = int.Parse(Console.ReadLine());
            int kgCookies = int.Parse(Console.ReadLine());
            double expenses = easterBread * 3.20 + numofEggCartons * 4.35 + kgCookies * 5.40;
            int numbOfEggs = 12 * numofEggCartons;
            expenses += numbOfEggs * 0.15;
            Console.WriteLine($"{expenses:f2}");
        }
    }
}
