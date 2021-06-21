using System;

namespace Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoint = 5364;
            int endPoint = 8848;
            int days = 5;
            string input = Console.ReadLine();
            int distance = 0;
            int daysNeeded = 1;
            while (input != "END")
            {
                if (input == "Yes")
                {
                    days--;
                    daysNeeded++;
                }
                if (days == 0)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine(startPoint);
                    break;
                }
                distance = int.Parse(Console.ReadLine());
                startPoint += distance;
                if (startPoint >= endPoint)
                {
                    Console.WriteLine($"Goal reached for {daysNeeded} days!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "END")
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(startPoint);
            }
        }
    }
}
