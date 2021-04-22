using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProlbemsCount = 0;
            double gradeSum = 0;
            string lasProblem = "";
            bool isFailed = true;
            while (failedTimes < failedThreshold)
            {
                string problemName = Console.ReadLine();
                if ("Enough"==problemName)
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <=4)
                {
                    failedTimes++;
                }
                gradeSum += grade;
                solvedProlbemsCount++;
                lasProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedTimes} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum/solvedProlbemsCount:f2}");
                Console.WriteLine($"Number of problems: {solvedProlbemsCount}");
                Console.WriteLine($"Last problem: {lasProblem}");
            }
        }
    }
}
