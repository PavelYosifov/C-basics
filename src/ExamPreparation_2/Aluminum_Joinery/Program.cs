using System;

namespace Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int joineryNum = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string delivery = Console.ReadLine();// with or without
            double pricePerUnit = 0;
            double deliveryPrice = 60;
            double total = 0;
            if (joineryNum<10)
            {
                Console.WriteLine("Invalid order");
                Environment.Exit(0);
            }
            switch (type)
            {
                case "90X130":
                    pricePerUnit = 110;
                    total = pricePerUnit * joineryNum;
                    if (joineryNum>30 &&joineryNum<=60)
                    {
                        total *= 0.95;
                    }
                    else if (joineryNum>60)
                    {
                        total *= 0.92;
                    }
                    break;
                case "100X150":
                    pricePerUnit = 140;
                    total = pricePerUnit * joineryNum;
                    if (joineryNum > 40 && joineryNum <=80)
                    {
                        total*= 0.94;
                    }
                    else if (joineryNum > 80)
                    {
                        total *=0.9;
                       
                    }
                    break;
                case "130X180":
                    pricePerUnit = 190;
                    total = pricePerUnit * joineryNum;
                    if (joineryNum > 20 && joineryNum <=50)
                    {
                        total *= 0.93;
                    }
                    else if (joineryNum > 50)
                    {
                        total *= 0.88;
                    }
                    break;
                case "200X300":
                    pricePerUnit = 250;
                    total = pricePerUnit * joineryNum;
                    if (joineryNum > 25 && joineryNum <=50)
                    {
                        total *=0.91;
                    }
                    else if (joineryNum > 50)
                    {
                        total *= 0.86;
                    }
                    break;
            }
            if (delivery== "With delivery" && joineryNum>99)
            {
                total += deliveryPrice;
                total *=0.96;
            }
            else if (delivery == "With delivery")
            {
                total += deliveryPrice;
            }
            Console.WriteLine($"{total:f2} BGN");
        }
    }
}
