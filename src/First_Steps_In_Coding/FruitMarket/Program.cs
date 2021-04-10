using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double strawberriesPricePerKG = double.Parse(Console.ReadLine());
            double bananasKG = double.Parse(Console.ReadLine());
            double orangesKG = double.Parse(Console.ReadLine());
            double raspberriesKG = double.Parse(Console.ReadLine());
            double strawberriesKG = double.Parse(Console.ReadLine());
            //Calculations
            double rasberriesPricePerKG = strawberriesPricePerKG / 2;
            double orangesPricePerKG = rasberriesPricePerKG - (rasberriesPricePerKG * 0.40);
            double bananasPricePerKG = rasberriesPricePerKG - (rasberriesPricePerKG * 0.80);
            double rasberriesPrice = raspberriesKG * rasberriesPricePerKG;
            double orangesPrice = orangesKG * orangesPricePerKG;
            double bananasPrice = bananasKG * bananasPricePerKG;
            double strawberriesPrice = strawberriesKG * strawberriesPricePerKG;

            double totalSum = strawberriesPrice+orangesPrice+bananasPrice+rasberriesPrice;
            //Output
            Console.WriteLine($"{totalSum:f2}!");

        }
    }
}
