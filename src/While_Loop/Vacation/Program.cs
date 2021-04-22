using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double balance = double.Parse(Console.ReadLine());
            int dayCount = 0;
            int spendCount = 0;
            while (balance < neededMoney && spendCount < 5)
            {

                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                dayCount++;
                if (input == "spend")
                {
                    balance -= money;
                    spendCount++;
                    if (money > balance)
                    {
                        balance = 0;
                    }
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(dayCount);
                        break;
                    }
                }
                else if (input == "save")
                {
                    spendCount = 0;
                    balance += money;
                }
                if (balance >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {dayCount} days.");
                    break;
                }
            }
        }
    }
}
