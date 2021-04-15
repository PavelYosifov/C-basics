using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            //calculations
            int totalTime = firstTime + secondTime + thirdTime;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            Console.WriteLine($"{minutes}:{seconds:d2}");//d2 is incase the seconds are less than 10 so it shows 03 for example
            Console.WriteLine($"{minutes}:{seconds}");

        }
    }
}
