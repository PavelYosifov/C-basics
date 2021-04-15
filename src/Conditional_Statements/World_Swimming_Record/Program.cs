using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMin = double.Parse(Console.ReadLine());
            //calculations
            double time = distance * timePerMin;
            double delay = Math.Floor(distance / 15) * 12.5;
            double totalTime = time + delay;
            if (totalTime >= record)
            {

                Console.WriteLine($" No, he failed! He was {totalTime - record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }

        }
    }
}