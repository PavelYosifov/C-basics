using System;

namespace GraduationPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 1;
            string name = Console.ReadLine();
            double evaluation = 0.0;
            double totalEvaluation = 0;
            double average = 0;
            int repeatedGrade =0;
            bool excluded = false;
            while (grade <= 12)
            {
                evaluation = double.Parse(Console.ReadLine());
                if (repeatedGrade == 1)//Here its 1 because the first time "repeatedGrade" will be 0 if he fail and if he do it again "repeatedGrade" will be 1 and in this case he will be excluded
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    excluded = true;
                    Environment.Exit(0);
                }
                if (evaluation < 4)
                {
                    repeatedGrade++;
                    continue;
                }
                
                totalEvaluation += evaluation;
                grade++;
            }
            if (!excluded)
            {
                average = totalEvaluation / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
