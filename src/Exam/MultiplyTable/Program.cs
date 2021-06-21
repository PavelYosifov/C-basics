using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstNum = number%10;
            int secondNum = (number/10)%10;
            int thirdNum = number/100;
            for (int i = 1; i <= thirdNum; i++)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    for (int p = 1; p <= firstNum; p++)
                    {
                        Console.WriteLine($"{i} * {j} * {p} = {i * j * p};");
                    }
                }
            }
        }
    }
}
