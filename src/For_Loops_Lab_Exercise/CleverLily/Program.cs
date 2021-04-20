using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            int toycount = 0;
            double toySum = 0;
            double money = 0;
            int temp = 10;
            double total = 0;
            for (int i = 1; i <= lilyAge; i++)
            {
                if (i % 2 == 0)
                {
                    money += temp;
                    temp += 10;
                }
                else
                {
                    toycount++;
                }
            }
            money -= lilyAge / 2;
            toySum = toyPrice * toycount;
            total = (money + toySum);
            if (total>=washingMachinePrice)
            {
                Console.WriteLine($"Yes! {total-washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice-total:f2}");
            }
        }
    }
}
