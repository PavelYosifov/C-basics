using System;

namespace Exam_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double average = 0;
            int goodCount = 0;
            int failCount = 0;
            int decentCount = 0;
            int excellentCount = 0;
            double grade = 0;
            double gradeSum = 0;
            const double doubleConverter = 1.0;
            double goodAvr = 0;
            double failAvr = 0;
            double decentAvr = 0;
            double excellentAvr = 0;
            for (int i = 0; i < n; i++)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade < 3)
                {
                    failCount++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    decentCount++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    goodCount++;
                }
                else if (grade >= 5)
                {
                    excellentCount++;
                }
                gradeSum += grade;
            }
            average = gradeSum / n;

            goodAvr = doubleConverter* goodCount / n *100 ;
            failAvr = doubleConverter * failCount / n * 100;
            decentAvr = doubleConverter * decentCount / n * 100;
            excellentAvr = doubleConverter * excellentCount / n * 100;
            Console.WriteLine($"Top students: {excellentAvr:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodAvr:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {decentAvr:f2}%");
            Console.WriteLine($"Fail: {failAvr:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
