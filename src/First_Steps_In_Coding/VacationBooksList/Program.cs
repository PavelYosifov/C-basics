using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            //Calculations
            double totalTime = pages / pagesPerHour;
            double hoursPerDay = totalTime / days;
            //Output
            Console.WriteLine(hoursPerDay);
        }
    }
}
