using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            //static numbers
            double price = 7.61;
            //input
            double land = double.Parse(Console.ReadLine());
            //calculations
            double cost = price*land;
            double discount = cost *0.18;
            double total = cost-discount;
            //output
            Console.WriteLine($"The final price is: {total} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
