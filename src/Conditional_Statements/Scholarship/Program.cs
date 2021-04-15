using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double income = double.Parse(Console.ReadLine());
            double avrGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            if (minSalary >= income)
            {
                if (avrGrade >= 4.50 && avrGrade < 5.50)
                {
                    double socialSch =Math.Floor( minSalary * 0.35);
                    Console.WriteLine($"You get a Social scholarship {socialSch} BGN");
                }
                else if (avrGrade >= 5.50)
                {
                    double socialSch = Math.Floor(minSalary * 0.35);
                    double gradeSch = Math.Floor(avrGrade * 25);
                    if (gradeSch >= socialSch)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {gradeSch} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {socialSch} BGN");
                    }
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
