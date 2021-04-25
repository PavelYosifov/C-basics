using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
               string destination = Console.ReadLine();
                if (destination=="End")
                {
                    break;
                }
               double neededMoney = double.Parse(Console.ReadLine());
                double sum = 0;
                while (sum < neededMoney)
                {
                   double income = double.Parse(Console.ReadLine());
                   sum += income;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
