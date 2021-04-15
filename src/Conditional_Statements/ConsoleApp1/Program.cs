using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            //condition
            if (a>b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }
    }
}
