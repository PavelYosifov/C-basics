using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //static numbers or price tags for this program
            double puzzle = 2.60;
            double doll = 3.00;
            double teddybear = 4.10;
            double minion = 8.20;
            double truck = 2.00;
            //inputs
            double holidayPrice = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int numDolls = int.Parse(Console.ReadLine());
            int numTeddybears = int.Parse(Console.ReadLine());
            int numMinions = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());
            //calculations, conditions and their outputs
            double sum = (puzzle * numPuzzles) + (doll * numDolls) + (teddybear * numTeddybears) + (minion * numMinions) + (truck * numTrucks);
            int totalToys = numPuzzles + numDolls + numTeddybears + numMinions + numTrucks;
            if (totalToys >= 50) //checking if total toys purchased are above 50 if it's above 50 the customer receives 25% discount
            {
                double discount = sum * 0.25;
                sum = sum - discount;
            }
            double rent = sum * 0.10;
            double profit = sum - rent;
            if (profit >= holidayPrice)
            {
                double freeMoney = profit - holidayPrice;
                Console.WriteLine($"Yes! {freeMoney:f2} lv left.");
            }
            else
            {
                double neededMoney = holidayPrice - profit;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }
        }
    }
}
