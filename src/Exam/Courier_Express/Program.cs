using System;

namespace Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double pricePerKilometer = 0;
            double totalprice = 0;
            switch (type)
            {
                case "standard":
                    if (weight < 1)
                    {
                        pricePerKilometer = 0.03;
                        totalprice = pricePerKilometer * distance;
                    }
                    else if (weight >= 1 && weight < 10)
                    {
                        pricePerKilometer = 0.05;
                        totalprice = pricePerKilometer * distance;
                    }
                    else if (weight >= 10 && weight < 40)
                    {
                        pricePerKilometer = 0.10;
                        totalprice = pricePerKilometer * distance;
                    }
                    else if (weight >= 40 && weight < 90)
                    {
                        pricePerKilometer = 0.15;
                        totalprice = pricePerKilometer * distance;
                    }
                    else if (weight >= 90 && weight < 150)
                    {
                        pricePerKilometer = 0.20;
                        totalprice = pricePerKilometer * distance;
                    }
                    break;
                case "express":
                    double additionalPrice = 0;
                    double newWeight = 0;
                    if (weight < 1)
                    {
                        pricePerKilometer = 0.03;
                        totalprice = pricePerKilometer * distance;
                        pricePerKilometer = 0.03 * 0.8;
                        newWeight = weight * pricePerKilometer;
                        additionalPrice = distance * newWeight;
                        totalprice += additionalPrice;

                    }
                    else if (weight >= 1 && weight < 10)
                    {
                        pricePerKilometer = 0.05;
                        totalprice = pricePerKilometer * distance;
                        pricePerKilometer = 0.5 * 0.4;
                        newWeight = weight * pricePerKilometer;
                        additionalPrice = distance * newWeight;
                        totalprice += additionalPrice;
                    }
                    else if (weight >= 10 && weight < 40)
                    {
                        pricePerKilometer = 0.10;
                        totalprice = pricePerKilometer * distance;
                        pricePerKilometer = 0.10 * 0.05;
                        newWeight = weight * pricePerKilometer;
                        additionalPrice = distance * newWeight;
                        totalprice += additionalPrice;
                    }
                    else if (weight >= 40 && weight < 90)
                    {
                        pricePerKilometer = 0.15;
                        totalprice = pricePerKilometer * distance;
                        pricePerKilometer = 0.15 * 0.02;
                        newWeight = weight * pricePerKilometer;
                        additionalPrice = distance * newWeight;
                        totalprice += additionalPrice;
                    }
                    else if (weight >= 90 && weight < 150)
                    {
                        pricePerKilometer = 0.20;
                        totalprice = pricePerKilometer * distance;
                        pricePerKilometer = 0.20 * 0.01;
                        newWeight = weight * pricePerKilometer;
                        additionalPrice = distance * newWeight;
                        totalprice += additionalPrice;
                    }
                    break;
            }
            Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {totalprice:f2} lv.");
        }
    }
}
