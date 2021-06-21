using System;

namespace Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractLenght = Console.ReadLine();//1 or 2 years
            string contractType = Console.ReadLine();//Small, Middle, Large, ExtraLarge
            string mobile = Console.ReadLine();//yes or no
            int months = int.Parse(Console.ReadLine());
            double monthlyPrice = 0;
            double totalPrice = 0;
            switch (contractLenght)
            {
                case "one":
                    switch (contractType)
                    {
                        case "Small":
                            monthlyPrice = 9.98;
                            break;
                        case "Middle":
                            monthlyPrice = 18.99;
                            break;
                        case "Large":
                            monthlyPrice = 25.98;
                            break;
                        case "ExtraLarge":
                            monthlyPrice = 35.99;
                            break;
                    }
                    break;
                case "two":
                    switch (contractType)
                    {
                        case "Small":
                            monthlyPrice =8.58;
                            break;
                        case "Middle":
                            monthlyPrice = 17.09;
                            break;
                        case "Large":
                            monthlyPrice = 23.59;
                            break;
                        case "ExtraLarge":
                            monthlyPrice = 31.79;
                            break;
                    }
                    break;
            }
            if (mobile=="yes")
            {
                if (monthlyPrice<=10)
                {
                    monthlyPrice += 5.5;
                }
                else if (monthlyPrice <= 30)
                {
                    monthlyPrice += 4.35;
                }
                else
                {
                    monthlyPrice += 3.85;
                }
            }
            totalPrice = monthlyPrice * months;
            if (contractLenght=="two")
            {
                totalPrice -= totalPrice* 0.0375;
            }
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
