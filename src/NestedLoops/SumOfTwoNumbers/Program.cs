using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            bool flag = false;
            for (int i = x1; i <= x2; i++)
            {
                for (int j = x1; j <= x2; j++)
                {
                    sum = i + j;
                    count++;
                    if (sum == n)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {n})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{count} combinations - neither equals {n}");
            }
        }
    }
}
