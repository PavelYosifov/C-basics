using System;

namespace DeerOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());//in kg
            double foodDeerOne = double.Parse(Console.ReadLine());
            double foodDeerTwo = double.Parse(Console.ReadLine());
            double foodDeerThree = double.Parse(Console.ReadLine());

            double foodNeededDeerOne = days*foodDeerOne;
            double foodNeededDeerTwo = days*foodDeerTwo;
            double foodNeededDeerThree = days*foodDeerThree;
            double totalFoodNeeded = foodNeededDeerOne+foodNeededDeerTwo+foodNeededDeerThree;
            if (food >= totalFoodNeeded)
            {
                double foodLeft = food - totalFoodNeeded;  
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                double foodNeeded = totalFoodNeeded - food;
                Console.WriteLine($"{(int)Math.Ceiling(foodNeeded)} more kilos of food are needed.");
            }
        }
    }
}
