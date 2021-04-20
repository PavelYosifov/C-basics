using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string tabName = Console.ReadLine();
                if (tabName == "Facebook")
                {
                    salary -= 150;
                }
                if (tabName == "Instagram")
                {
                    salary -= 100;
                }
                if (tabName == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary>0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
