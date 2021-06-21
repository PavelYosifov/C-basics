using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string ball = "";
            int redCount = 0;
            int orangeCount = 0;
            int yellowCount = 0;
            int whiteCount = 0;
            int blackCount = 0;
            int otherCount = 0;
            int points = 0;
            for (int i = 0; i < n; i++)
            {
                ball = Console.ReadLine();
                if (ball=="red")
                {
                    redCount++;
                    points += 5;
                }
                else if (ball == "orange")
                {
                    orangeCount++;
                    points += 10;
                }
                else if (ball == "yellow")
                {
                    yellowCount++;
                    points += 15;
                }
                else if (ball == "white")
                {
                    whiteCount++;
                    points += 20;
                }
                else if (ball == "black")
                {
                    blackCount++;
                    points /= 2;
                }
                else
                {
                    otherCount++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {redCount}");
            Console.WriteLine($"Points from orange balls: {orangeCount}");
            Console.WriteLine($"Points from yellow balls: {yellowCount}");
            Console.WriteLine($"Points from white balls: {whiteCount}");
            Console.WriteLine($"Other colors picked: {otherCount}");
            Console.WriteLine($"Divides from black balls: {blackCount}");
        }
    }
}
