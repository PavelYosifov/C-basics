using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //static number
            double usdCurrentCourse = 1.79549;
            //input
            double usd = double.Parse(Console.ReadLine());
            //calculations
            double bgn = usd * usdCurrentCourse;
            //output
            Console.WriteLine(bgn);
        }
    }
}
