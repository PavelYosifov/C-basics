using System;

namespace Time_Plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //calculations
            minutes += 15;
            if (minutes >= 60)
            {
                hours += 1;
            }
            hours %= 24;
            minutes %= 60;
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
