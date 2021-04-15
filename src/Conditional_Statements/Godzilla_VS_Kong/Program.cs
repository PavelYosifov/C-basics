using System;

namespace Godzilla_VS_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());
            //calculations
            double totalClPrice = actors * clothesPrice;
            double decor = budget * 0.1;
            if (actors>150)
            {
                totalClPrice -=totalClPrice* 0.1;
            }
            double totalPrice = decor + totalClPrice;
            if (budget>=totalPrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs { totalPrice-budget:f2} leva more.");
            }
        }
    }
}
