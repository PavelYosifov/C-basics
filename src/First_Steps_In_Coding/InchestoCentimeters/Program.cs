using System;

namespace InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double cen = double.Parse(Console.ReadLine());
            double inch = cen * 2.54;
            Console.WriteLine(inch);
        }
    }
}
