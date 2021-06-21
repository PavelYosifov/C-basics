using System;

namespace Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double bagCost = double.Parse(Console.ReadLine()); //cost for bag over 20kg
            double bagWeight = double.Parse(Console.ReadLine()); 
            int daysLeft = int.Parse(Console.ReadLine()); 
            int bagsNum = int.Parse(Console.ReadLine());
            double cost = 0;
            if (bagWeight<10)
            {
                bagCost -=bagCost * 0.8;
                
            }
            else if (bagWeight>=10 && bagWeight<=20)
            {
                bagCost -=bagCost/ 2;
               
            }
            if (daysLeft>30)
            {
                bagCost =bagCost+bagCost* 0.1;
            }
            else if (daysLeft>=7&&daysLeft<=30)
            {
                bagCost = bagCost + bagCost * 0.15;
                
            }
            else
            {
                bagCost = bagCost + bagCost * 0.4;
            }
            cost = bagsNum * bagCost;
            Console.WriteLine($" The total price of bags is: {cost:f2} lv. ");
        }
    }
}
