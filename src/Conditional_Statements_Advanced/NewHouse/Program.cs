using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();//"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            int numOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double flowerPrice = 0;
            double discount = 0;
            double totalPrice = 0;
            switch (flower)
            {
                case "Roses":
                    flowerPrice = 5;
                    if (numOfFlowers > 80)
                    {
                        discount = 0.1;
                    }
                    break;
                case "Dahlias":
                    flowerPrice = 3.8;
                    if (numOfFlowers > 90)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Tulips":
                    flowerPrice = 2.8;
                    if (numOfFlowers > 80)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Narcissus":
                    flowerPrice = 3;
                    if (numOfFlowers < 120)
                    {
                        discount = -0.15;
                    }
                    break;
                case "Gladiolus":
                    flowerPrice = 2.5;
                    if (numOfFlowers < 80)
                    {
                        discount = -0.2;
                    }
                    break;
            }
            totalPrice = numOfFlowers * flowerPrice;
            totalPrice = totalPrice - (totalPrice * discount);
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {flower} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
