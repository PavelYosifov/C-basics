using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            //calculations
            if (input == "mm" && output == "cm")
            {
                num *= 0.1;
            }
            else if (input == "mm" && output == "m")
            {
                num *= 0.001;
            }
            else if (input == "cm" && output == "mm")
            {
                num *= 10;
            }
            else if (input == "cm" && output == "m")
            {
                num *= 0.01;
            }
            else if (input == "m" && output == "mm")
            {
                num *= 1000;
            }
            else if (input == "m" && output == "cm")
            {
                num *= 100;
            }
            Console.WriteLine($"{ num:f3}");
        }
    }
}
