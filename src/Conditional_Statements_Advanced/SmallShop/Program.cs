using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();//coffee, water, beer, sweets, peanuts
            string city = Console.ReadLine();//Sofia, Plovdiv or Varna
            double amount = double.Parse(Console.ReadLine());
            double price;
            double cost;
            switch (product)
            {
                case "coffee":
                    if (city == "Sofia")
                    {
                        cost = 0.5;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    else if (city == "Plovdiv")
                    {
                        cost = 0.4;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    else if (city == "Varna")
                    {
                        cost = 0.45;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    break;
                case "water":
                    if (city == "Sofia")
                    {
                        cost = 0.8;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    else if (city == "Plovdiv")
                    {
                        cost = 0.7;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    else if (city == "Varna")
                    {
                        cost = 0.7;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    break;
                case "beer":
                    if (city == "Sofia")
                    {
                        cost = 1.2;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    else if (city == "Plovdiv")
                    {
                        cost = 1.15;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    else if (city == "Varna")
                    {
                        cost = 1.1;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    break;
                case "sweets":
                    if (city == "Sofia")
                    {
                        cost = 1.45;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    else if (city == "Plovdiv")
                    {
                        cost = 1.3;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    else if (city == "Varna")
                    {
                        cost = 1.35;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    break;
                case "peanuts":
                    if (city == "Sofia")
                    {
                        cost = 1.6;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    else if (city == "Plovdiv")
                    {
                        cost = 1.5;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    else if (city == "Varna")
                    {
                        cost = 1.55;
                        price = cost * amount;
                        Console.WriteLine(price);
                    }
                    break;
            }
        }
    }
}
