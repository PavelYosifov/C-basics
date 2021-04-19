using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double income = 0;
            if (movieType == "Premiere")
            {
                income = (rows * colums) * 12.00;
            }
            else if (movieType == "Normal")
            {
                income = (rows * colums) * 7.50;
            }
            else
            {
                income = (rows * colums) * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
