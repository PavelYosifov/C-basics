using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();//summer or winter
            double moneySpent = 0;
            string destination = "";
            string typeOfHoliday = "";//Camp or Hotel
            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
            }
            else
            {
                destination = "Europe";
            }
            switch (destination)
            {
                case "Bulgaria":
                    if (season == "summer")
                    {
                        moneySpent = budget * 0.3;
                        typeOfHoliday = "Camp";
                    }
                    else
                    {
                        moneySpent = budget * 0.7;
                        typeOfHoliday = "Hotel";
                    }
                    break;
                case "Balkans":
                    if (season == "summer")
                    {
                        moneySpent = budget * 0.4;
                        typeOfHoliday = "Camp";
                    }
                    else
                    {
                        moneySpent = budget * 0.8;
                        typeOfHoliday = "Hotel";
                    }
                    break;
                case "Europe":
                    moneySpent = budget * 0.9;
                    typeOfHoliday = "Hotel";
                    break;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfHoliday} - {moneySpent:f2}");
        }
    }
}
