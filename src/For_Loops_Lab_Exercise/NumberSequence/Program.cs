using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < min) min = num;
                if (num > max) max = num;
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");

        }
    }
}
