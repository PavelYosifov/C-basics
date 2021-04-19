using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();//"Spring", "Summer", "Autumn", "Winter"
            int fishermen = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double boatPrice = 0;
            double discount = 0;
            switch (season)
            {
                case "Spring":
                    boatPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case "Winter":
                    boatPrice = 2600;
                    break;
            }
            if (fishermen <= 6)
            {
                discount = 0.1;
            }
            else if (fishermen > 6 && fishermen <= 11)
            {
                discount = 0.15;
            }
            else
            {
                discount = 0.25;
            }
            totalPrice = boatPrice - (boatPrice * discount);
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                totalPrice = totalPrice - (totalPrice * 0.05);
                
            }
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
