using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > sum)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine(sum);
        }
    }
}
