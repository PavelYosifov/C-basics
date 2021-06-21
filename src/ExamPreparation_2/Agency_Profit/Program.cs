using System;

namespace Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string company = Console.ReadLine();
            int numElderlyTicket = int.Parse(Console.ReadLine());
            int numChildTicket = int.Parse(Console.ReadLine());
            double elderlyCost = double.Parse(Console.ReadLine());
            double fees = double.Parse(Console.ReadLine());
            double totalCost = 0;
            double profit = 0;

            double childCost = elderlyCost *0.3;
            elderlyCost += fees;
            childCost += fees;
            totalCost = (numElderlyTicket * elderlyCost) + (numChildTicket * childCost);
            profit = totalCost- totalCost * 0.8;
            Console.WriteLine($"The profit of your agency from {company} tickets is {profit:f2} lv.");
        }
    }
}
