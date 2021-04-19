using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();//positive or negative
            double pricePerNight = 0;
            double total;
            double discount = 0;
            switch (roomType)
            {
                case "room for one person":
                    pricePerNight = 18.00;
                    break;
                case "apartment":
                    pricePerNight = 25.00;
                    if (numOfDays < 10)
                    {
                        discount = 0.3;
                    }
                    else if (numOfDays >= 10 && numOfDays <= 15)
                    {
                        discount = 0.35;
                    }
                    else
                    {
                        discount = 0.5;
                    }
                    break;
                case "president apartment":
                    pricePerNight = 35.00;
                    if (numOfDays < 10)
                    {
                        discount = 0.1;
                    }
                    else if (numOfDays >= 10 && numOfDays <= 15)
                    {
                        discount = 0.15;
                    }
                    else
                    {
                        discount = 0.2;
                    }
                    break;
            }
            total = numOfDays * pricePerNight;
            total = total - (total * discount);
            if (feedback == "positive")
            {
                total = total + (total * 0.25);
            }
            else
            {
                total = total - (total * 0.10);
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
