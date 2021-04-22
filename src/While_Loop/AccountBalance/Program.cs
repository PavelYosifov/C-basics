using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0.0;
            while (input != "NoMoreMoney")
            {
                double p = double.Parse(input);
                if (p < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += p;
                Console.WriteLine($"Increase: {p:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
