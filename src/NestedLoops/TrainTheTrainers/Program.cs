using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double average = 0;
            double averageOfAllGrades = 0;
            double sumOfAllGrades = 0;
            int gradeCount = 0;
            while (name != "Finish")
            {

                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    sumOfAllGrades += grade;
                    gradeCount++;
                }
                average = sum / n;
                Console.WriteLine($"{name} - {average:f2}.");
                name = Console.ReadLine();
            }
            averageOfAllGrades = sumOfAllGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is {averageOfAllGrades:f2}.");
        }
    }
}
