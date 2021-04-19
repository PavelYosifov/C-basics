using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price;
            double cost;
            switch (fruit)
            {
                case "banana":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 2.5;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 2.7;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "apple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 1.2;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 1.25;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "orange":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 0.85;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 0.9;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapefruit":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 1.45;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 1.6;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "kiwi":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 2.7;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 3.0;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "pineapple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 5.5;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 5.6;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapes":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 3.85;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 4.2;
                            cost = price * quantity;
                            Console.WriteLine($"{cost:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
