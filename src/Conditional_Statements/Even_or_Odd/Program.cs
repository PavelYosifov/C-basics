using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int num = int.Parse(Console.ReadLine());
            //condition
            if (num % 2 == 0)
            {
                //output 1
                Console.WriteLine("even");
            }
            else
            {
                //output 2
                Console.WriteLine("odd");
            }
        }
    }
}
